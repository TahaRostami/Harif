using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tataiee.Harif.Infrastructures.GeneralEnums;
using Tataiee.Harif.Infrastructures.OfferesdCourses;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.OfferedCourses;

namespace Tataiee.Harif.Infrastructures.OfferesdCourses
{
    /// <summary>
    /// 
    /// </summary>
    public class FileServiceProvider
    {
        /// <summary>
        /// Serializes represented object to xml file
        /// </summary>
        /// <typeparam name="T">Type of represented object</typeparam>
        /// <param name="filename">Name and path of the file</param>
        /// <param name="obj">Represented object</param>
        public static void SerializeToXmlFile<T>(string filename, T obj)
        {
            // Insert code to set properties and fields of the object.  
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(T));
            // To write to a file, create a StreamWriter object.  
            StreamWriter myWriter = new StreamWriter(filename);
            mySerializer.Serialize(myWriter, obj);
            myWriter.Close();
        }
        /// <summary>
        /// Deserializes specific object from xml file representing the object
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="filename">Name and path of the file representing the object</param>
        /// <param name="myObject">Object</param>
        public static void DeserializeFromXmlFile<T>(string filename, out T myObject)
        {
            // Construct an instance of the XmlSerializer with the type  
            // of object that is being deserialized.  
            XmlSerializer mySerializer1 =
            new XmlSerializer(typeof(T));
            // To read the file, create a FileStream.  
            FileStream myFileStream =
            new FileStream(filename, FileMode.Open);
            // Call the Deserialize method and cast to the object type.  
            myObject = (T)mySerializer1.Deserialize(myFileStream);
            myFileStream.Close();
        }


        /// <summary>
        /// Converts from basic form (e.g. html file retrieved from 'Golestan' ) to Intermediate xml format and save it
        /// </summary>
        /// <param name="inputFile">basic form (e.g. html file retrieved from 'Golestan' )</param>
        /// <param name="saveFile">Name and path of the file</param>
        /// <returns></returns>
        public static string ConvertFromOfferedCoursesBasicFormToIntermediateXmlFormat(string inputFile, string saveFile)
        {
            if (inputFile == null)
            {
                throw new ArgumentNullException(nameof(inputFile));
            }

            string fileContext = File.ReadAllText(inputFile);
            int start = fileContext.IndexOf("<tbody>");
            int end = fileContext.LastIndexOf("</tbody>") + "</tbody>".Length - 1;
            fileContext = fileContext.Substring(start, end - start + 1);
            start = fileContext.IndexOf("<tr");
            end = fileContext.IndexOf(">", start);
            fileContext = fileContext.Replace(fileContext.Substring(start, end - start + 1), "<tr>");
            fileContext = fileContext.Replace("<br>", "#");//newline
            string head = "<?xml version=\"1.0\" standalone=\"yes\"?>";
            fileContext = head + Environment.NewLine + fileContext;

            fileContext = fileContext.Replace("دانشكده درس         ", "دانشكده درس");
            fileContext = fileContext.Replace("گروه آموزشي         ", "گروه آموزشي");


            int s1 = fileContext.IndexOf("<td>دانشكده درس</td>");
            int l = "<td>دانشكده درس</td>".Length;
            string part1 = fileContext.Substring(0, s1 + l).Replace("<td>دانشكده درس</td>", "<td>کد دانشکده درس</td>");
            string part2 = fileContext.Substring(s1 + l + 1);
            fileContext = part1 + part2;

            s1 = fileContext.IndexOf("<td>گروه آموزشي</td>");
            l = "<td>گروه آموزشي</td>".Length;
            part1 = fileContext.Substring(0, s1 + l).Replace("<td>گروه آموزشي</td>", "<td>کد گروه آموزشي</td>");
            part2 = fileContext.Substring(s1 + l + 1);
            fileContext = part1 + part2;


            File.WriteAllText(saveFile, fileContext);

            return fileContext;
        }


        /// <summary>
        ///  Read intermediate file and push it to DataTable object (i.e. dt)
        /// </summary>
        /// <param name="filename">Name and path of the intermediate file</param>
        /// <param name="dt">object</param>
        public static void ReadOfferedCoursesTableRowFromIntermediateXmlFile(string filename, out DataTable dt)
        {
            XDocument doc = XDocument.Load(filename);

            dt = new DataTable("chart");

            int cnt = 0;

            foreach (var el1 in doc.Root.Elements())
            {
                DataRow dr = null;
                if (cnt != 0)
                    dr = dt.NewRow();
                int j = 0;
                foreach (var el2 in el1.Elements())
                {
                    if (cnt == 0)
                    {
                        dt.Columns.Add(el2.Value);
                    }
                    else
                    {
                        dr[j] = el2.Value;
                    }
                    j++;
                }
                if (cnt != 0)
                    dt.Rows.Add(dr);
                cnt++;
            }

        }

        /// <summary>
        /// Converts Intermediate file to Intermediate2 file and returns a list of 'OfferedCoursesRow' objects
        /// </summary>
        /// <param name="intermediateFile">Name and path of the intermediate file</param>
        /// <param name="saveFile">Name and path of the intermediate2 file</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static List<OfferedCoursesRow> ConvertFromOfferedCoursesIntermediateXmlToIntermediate2XmlFormat(string intermediateFile, string saveFile, bool save = true)
        {
            List<OfferedCoursesRow> ocr = new List<OfferedCoursesRow>();

            DataTable dt;
            ReadOfferedCoursesTableRowFromIntermediateXmlFile(intermediateFile, out dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                OfferedCoursesRow newItem = new OfferedCoursesRow();

                newItem.DepartmentId = dr[0].ToString();
                newItem.DepartmentName = dr[1].ToString();
                newItem.EducationalGroupId = dr[2].ToString();
                newItem.EducationalGroupName = dr[3].ToString();
                newItem.Id = dr[4].ToString();
                newItem.CourseTitle = dr[5].ToString();

                newItem.Units = int.Parse(dr[6].ToString());
                newItem.Status = dr[7].ToString() == "1" ? CourseStatus.PRACTICAL : CourseStatus.THERORYCAL;
                newItem.Capacity = int.Parse(dr[8].ToString());
                newItem.Registered = int.Parse(dr[9].ToString());
                newItem.InWaitingList = int.Parse(dr[10].ToString());
                newItem.Gender = dr[11].ToString() == "مختلط" ? Gender.COEDUCATIONAL : dr[11].ToString() == "مرد" ? Gender.MALE : Gender.FEMALE;
                newItem.ProfessorName = dr[12].ToString().Replace("#", "");

                newItem.RawStringTimeAndSitesAndExam = dr[13].ToString().TrimEnd().TrimStart();

                newItem.Description = dr[14].ToString();
                ocr.Add(newItem);
            }

            if (save)
                SerializeToXmlFile(saveFile, ocr);

            return ocr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the basic form file (e.g. html file from 'Golestan')</param>
        /// <param name="intermediateSaveFile">Name and path of the intermediate file</param>
        /// <param name="intermediate2SaveFile">Name and path of the intermediate2 file</param>
        /// <returns></returns>
        public static List<OfferedCoursesRow> ConvertFromOfferedCoursesBasicFormToIntermediate2XmlFormatWithSeperatedFiles(string inputFile, string intermediateSaveFile, string intermediate2SaveFile)
        {
            ConvertFromOfferedCoursesBasicFormToIntermediateXmlFormat(inputFile, intermediateSaveFile);
            return ConvertFromOfferedCoursesIntermediateXmlToIntermediate2XmlFormat(intermediateSaveFile, intermediate2SaveFile);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the intermediate file</param>
        /// <param name="saveFile">Name and path of the intermediate2 file</param>
        /// <returns></returns>
        public static List<OfferedCoursesRow> ConvertFromOfferedCoursesBasicFormToIntermediate2XmlFormat(string inputFile, string saveFile)
        {
            return ConvertFromOfferedCoursesBasicFormToIntermediate2XmlFormatWithSeperatedFiles(inputFile, saveFile, saveFile);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the intermediate file</param>
        /// <param name="saveFile">Name and path of the goal version file</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static List<GoalVersionOfferedCoursesRow> ConvertFromOfferedCoursesIntermediateFormToGoalVersionXmlFormat(string inputFile, string saveFile, bool save = true)
        {
            List<GoalVersionOfferedCoursesRow> ocr = new List<GoalVersionOfferedCoursesRow>();

            DataTable dt;
            ReadOfferedCoursesTableRowFromIntermediateXmlFile(inputFile, out dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                GoalVersionOfferedCoursesRow newItem = new GoalVersionOfferedCoursesRow();

                newItem.DepartmentId = dr[0].ToString();
                newItem.DepartmentName = dr[1].ToString();
                newItem.EducationalGroupId = dr[2].ToString();
                newItem.EducationalGroupName = dr[3].ToString();
                newItem.Id = dr[4].ToString();
                newItem.CourseTitle = dr[5].ToString();

                newItem.Units = int.Parse(dr[6].ToString());
                newItem.Status = dr[7].ToString() == "1" ? CourseStatus.PRACTICAL : CourseStatus.THERORYCAL;
                newItem.Capacity = int.Parse(dr[8].ToString());
                newItem.Registered = int.Parse(dr[9].ToString());
                newItem.InWaitingList = int.Parse(dr[10].ToString());
                newItem.Gender = dr[11].ToString() == "مختلط" ? Gender.COEDUCATIONAL : dr[11].ToString() == "مرد" ? Gender.MALE : Gender.FEMALE;
                newItem.ProfessorName = dr[12].ToString().Replace("#", "");

                string rawStringTimeAndSitesAndExam = dr[13].ToString().TrimEnd().TrimStart();
                newItem.TimeAndSitesAndExam = new TimeAndSitesAndExamParser().Parse(new TimeAndSitesAndExamTokenizer().Tokenize(rawStringTimeAndSitesAndExam));
                newItem.RawStringTimeAndSitesAndExam = rawStringTimeAndSitesAndExam.Replace("#", Environment.NewLine);

                newItem.Description = dr[14].ToString();
                ocr.Add(newItem);
            }

            if (save)
                SerializeToXmlFile(saveFile, ocr);
            return ocr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the intermediate2 file</param>
        /// <param name="saveFile">Name and path of the goal version file</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static List<GoalVersionOfferedCoursesRow> ConvertFromOfferedCoursesIntermediate2FormToGoalVersionXmlFormat(string inputFile, string saveFile, bool save = true)
        {
            List<OfferedCoursesRow> ocr1;
            DeserializeFromXmlFile(inputFile, out ocr1);

            List<GoalVersionOfferedCoursesRow> gvocr1 = new List<GoalVersionOfferedCoursesRow>();

            foreach (var ocr in ocr1)
            {
                var lst = new TimeAndSitesAndExamTokenizer().Tokenize(ocr.RawStringTimeAndSitesAndExam);
                TimeAndSitesAndExamParser parser = new TimeAndSitesAndExamParser();
                TimeAndSiteAndExams tasax = parser.Parse(lst);

                GoalVersionOfferedCoursesRow goalV = new GoalVersionOfferedCoursesRow();
                goalV.Capacity = ocr.Capacity;
                goalV.CourseTitle = ocr.CourseTitle;
                goalV.DepartmentId = ocr.DepartmentId;
                goalV.DepartmentName = ocr.DepartmentName;
                goalV.Description = ocr.Description;
                goalV.EducationalGroupId = ocr.EducationalGroupId;
                goalV.EducationalGroupName = ocr.EducationalGroupName;
                goalV.Gender = ocr.Gender;
                goalV.Id = ocr.Id;
                goalV.InWaitingList = ocr.InWaitingList;
                goalV.ProfessorName = ocr.ProfessorName;
                goalV.RawStringTimeAndSitesAndExam = ocr.RawStringTimeAndSitesAndExam.Replace("#", Environment.NewLine);
                goalV.Registered = ocr.Registered;
                goalV.Status = ocr.Status;
                goalV.TimeAndSitesAndExam = tasax;
                goalV.Units = ocr.Units;

                gvocr1.Add(goalV);
            }

            if (save)
                SerializeToXmlFile(saveFile, gvocr1);

            return gvocr1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the basic form file (e.g. html file from 'Golestan')</param>
        /// <param name="intermediateSaveFile">Name and path of the intermediate file</param>
        /// <param name="intermediate2SaveFile">Name and path of the intermediate2 file</param>
        /// <param name="saveGoalVersionFile">Name and path of the goal version file</param>
        /// <returns></returns>
        public static List<GoalVersionOfferedCoursesRow> ConvertFromOfferedCoursesBasicFormToGoalVersionXmlFormatWithThreeSeperatedFiles(string inputFile, string intermediateSaveFile, string intermediate2SaveFile, string saveGoalVersionFile)
        {
            ConvertFromOfferedCoursesBasicFormToIntermediateXmlFormat(inputFile, intermediateSaveFile);
            ConvertFromOfferedCoursesIntermediateXmlToIntermediate2XmlFormat(intermediateSaveFile, intermediate2SaveFile, true);
            return ConvertFromOfferedCoursesIntermediate2FormToGoalVersionXmlFormat(intermediate2SaveFile, saveGoalVersionFile, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the basic form file (e.g. html file from 'Golestan')</param>
        /// <param name="intermediateSaveFile">Name and path of the intermediate file</param>
        /// <param name="saveGoalVersionFile">Name and path of the goal version file</param>
        /// <returns></returns>
        public static List<GoalVersionOfferedCoursesRow> ConvertFromOfferedCoursesBasicFormToGoalVersionXmlFormatWithTwoSeperatedFiles(string inputFile, string intermediateSaveFile, string saveGoalVersionFile)
        {
            ConvertFromOfferedCoursesBasicFormToIntermediateXmlFormat(inputFile, intermediateSaveFile);
            return ConvertFromOfferedCoursesIntermediateFormToGoalVersionXmlFormat(intermediateSaveFile, saveGoalVersionFile, true);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFile">Name and path of the basic form file (e.g. html file from 'Golestan')</param>
        /// <param name="saveFile">Name and path of the goal version file</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static List<GoalVersionOfferedCoursesRow> ConvertFromOfferedCoursesBasicFormToGoalVersionXmlFormat(string inputFile, string saveFile, bool save = true)
        {
            ConvertFromOfferedCoursesBasicFormToIntermediateXmlFormat(inputFile, saveFile);
            return ConvertFromOfferedCoursesIntermediateFormToGoalVersionXmlFormat(saveFile, saveFile, save);
        }


        /// <summary>
        /// Merging multiple files with identical types in a file
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged files should be saved</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <param name="xmlFiles">The files needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXmlFilesInOne(string saveFile, bool save, params string[] xmlFiles)
        {
            if (xmlFiles == null) throw new ArgumentNullException();
            XDocument xf = XDocument.Load(xmlFiles[0]);
            if (xmlFiles.Length == 1)
            {
                if (save)
                {
                    xf.Save(saveFile);
                }
                return xf;
            }
            else
            {
                for (int i = 1; i < xmlFiles.Length; i++)
                {
                    XDocument current = XDocument.Load(xmlFiles[i]);
                    xf = MergeMultipleXDocument(saveFile, false, xf, current);
                }
                return MergeMultipleXDocument(saveFile, save, xf);
            }
        }
        /// <summary>
        /// Merging multiple files with identical types in a file
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged files should be saved</param>
        /// <param name="xmlFiles">The files needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXmlFilesInOne(string saveFile, params string[] xmlFiles)
        {
            return MergeMultipleXmlFilesInOne(saveFile, true, xmlFiles);
        }
        /// <summary>
        /// Merging multiple files with identical types in a file
        /// </summary>
        /// <param name="xmlFiles">The files needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXmlFilesInOne(params string[] xmlFiles)
        {
            return MergeMultipleXmlFilesInOne("empty", false, xmlFiles);
        }

        /// <summary>
        /// Merging multiple 'XDocument' objects in a new one
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <param name="xdocs">The 'XDocument' objects needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXDocument(string saveFile, bool save, params XDocument[] xdocs)
        {
            if (xdocs == null) throw new ArgumentNullException();

            if (xdocs.Length == 1)
            {
                if (save && xdocs[0] != null)
                    xdocs[0].Save(saveFile);
                return xdocs[0];
            }
            else
            {
                XDocument xf = xdocs[0];
                for (int i = 1; i < xdocs.Length; i++)
                {
                    xf = MergeTwoXDocumnetObjectInOne(saveFile, xf, xdocs[i], false);
                }
                return MergeMultipleXDocument(saveFile, save, xf);
            }

        }
        /// <summary>
        /// Merging multiple 'XDocument' objects in a new one
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="xdocs">The 'XDocument' objects needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXDocument(string saveFile, params XDocument[] xdocs)
        {
            return MergeMultipleXDocument(saveFile, true, xdocs);
        }
        /// <summary>
        /// Merging multiple 'XDocument' objects in a new one
        /// </summary>
        /// <param name="xdocs">The 'XDocument' objects needed to be merged</param>
        /// <returns></returns>
        public static XDocument MergeMultipleXDocument(params XDocument[] xdocs)
        {
            return MergeMultipleXDocument("empty", false, xdocs);
        }

        /// <summary>
        /// Merging two 'XDocument' objects in a new one
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="xdoc1">object 1</param>
        /// <param name="xdoc2">object 2</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static XDocument MergeTwoXDocumnetObjectInOne(string saveFile, XDocument xdoc1, XDocument xdoc2, bool save = false)
        {
            if (xdoc1 == null || xdoc2 == null) throw new ArgumentNullException();
            XDocument xdoc3 = new XDocument(xdoc1);
            foreach (var el1 in xdoc2.Root.Elements())
            {
                xdoc3.Root.Add(el1);
            }
            if (save)
                xdoc3.Save(saveFile);
            return xdoc3;
        }
        /// <summary>
        /// Merging two 'XDocument' objects in a new one
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="xdoc1">object 1</param>
        /// <param name="xdoc2">object 2</param>
        /// <returns></returns>
        public static XDocument MergeTwoXDocumnetObjectInOne(string saveFile, XDocument xdoc1, XDocument xdoc2)
        {
            return MergeTwoXDocumnetObjectInOne(saveFile, xdoc1, xdoc2, true);
        }
        /// <summary>
        /// Merging two 'XDocument' objects in a new one
        /// </summary>
        /// <param name="xdoc1">object 1</param>
        /// <param name="xdoc2">object 2</param>
        /// <returns></returns>
        public static XDocument MergeTwoXDocumnetObjectInOne(XDocument xdoc1, XDocument xdoc2)
        {
            return MergeTwoXDocumnetObjectInOne("empty", xdoc1, xdoc2, false);
        }

        /// <summary>
        /// Merging two files with identical types in a file
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="xmlFile1">Name and path of the first input file</param>
        /// <param name="xmlFile2">Name and path of the second input file</param>
        /// <param name="save">Detremines whether you want to save the file or not</param>
        /// <returns></returns>
        public static XDocument MergeTwoXmlFilesInOne(string saveFile, string xmlFile1, string xmlFile2, bool save = true)
        {
            XDocument xdoc1 = XDocument.Load(xmlFile1);
            XDocument xdoc2 = XDocument.Load(xmlFile2);
            return MergeTwoXDocumnetObjectInOne(saveFile, xdoc1, xdoc2, save);
        }
        /// <summary>
        /// Merging two files with identical types in a file
        /// </summary>
        /// <param name="saveFile">Name and path of the palce where the merged objects should be saved</param>
        /// <param name="xmlFile1">Name and path of the first input file</param>
        /// <param name="xmlFile2">Name and path of the second input file</param>
        /// <returns></returns>
        public static XDocument MergeTwoXmlFilesInOne(string saveFile, string xmlFile1, string xmlFile2)
        {
            return MergeTwoXmlFilesInOne(saveFile, xmlFile1, xmlFile2, true);
        }
        /// <summary>
        /// Merging two files with identical types in a file
        /// </summary>
        /// <param name="xmlFile1">Name and path of the first input file</param>
        /// <param name="xmlFile2">Name and path of the second input file</param>
        /// <returns></returns>
        public static XDocument MergeTwoXmlFilesInOne(string xmlFile1, string xmlFile2)
        {
            return MergeTwoXmlFilesInOne("empty", xmlFile1, xmlFile2, false);
        }

    }
}

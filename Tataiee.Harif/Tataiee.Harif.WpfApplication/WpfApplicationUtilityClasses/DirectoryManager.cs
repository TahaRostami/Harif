using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses
{
    internal class DirectoryManager
    {
        internal const string DataDirectory = @"Data\";

        internal const string ReductionStep2SavedStatus = DataDirectory + @"ReductionStep2SavedStatus\";
        internal const string SaveColorOfferedCourses = @"SaveColorOfferedCourses.xml";
        internal const string SaveColorOfferedCourseRows = @"SaveColorOfferedCourseRows.xml";

        internal const string ReportsDirectory = DataDirectory + @"Reports\";
        internal const string AlgorithmReportsDirectory = ReportsDirectory + @"AlgorithmReports\";
        internal const string LastAlgorithmExeOutputs = AlgorithmReportsDirectory + @"LastAlgorithmExeOutputs\";

        internal const string EssentialInforamtion1Directory = DataDirectory + @"EssentialInforamtion1\";
        internal const string CreditDeterminerSavedName = @"CreditDeterminer.xml";
        internal const string CourseInformationSavedName = @"CourseInformation.xml";

        internal const string GoalVersionOfferedCoursesRowDirectory = DataDirectory + @"GoalVersionOfferedCoursesRow\";
        internal const string GoalVersionOfferedCoursesRowSavedName = @"GoalVersionOfferedCoursesRow.xml";


        internal static void TryCreateApplicationDirectoriesIfNotExists()
        {
            try
            {
                if (!Directory.Exists(DataDirectory))
                {
                    Directory.CreateDirectory(DataDirectory);
                }

                if (!Directory.Exists(EssentialInforamtion1Directory))
                {
                    Directory.CreateDirectory(EssentialInforamtion1Directory);
                }
                if (!Directory.Exists(GoalVersionOfferedCoursesRowDirectory))
                {
                    Directory.CreateDirectory(GoalVersionOfferedCoursesRowDirectory);
                }
                if (!Directory.Exists(ReductionStep2SavedStatus))
                {
                    Directory.CreateDirectory(ReductionStep2SavedStatus);
                }
                if (!Directory.Exists(ReportsDirectory))
                {
                    Directory.CreateDirectory(ReportsDirectory);
                }
                if (!Directory.Exists(AlgorithmReportsDirectory))
                {
                    Directory.CreateDirectory(AlgorithmReportsDirectory);
                }
                if (!Directory.Exists(LastAlgorithmExeOutputs))
                {
                    Directory.CreateDirectory(LastAlgorithmExeOutputs);
                }
                if (!Directory.Exists(Properties.Settings.Default.WeeklyProgramSavedDirectory))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.WeeklyProgramSavedDirectory);
                }
            }
            catch { }
        }

    }
}

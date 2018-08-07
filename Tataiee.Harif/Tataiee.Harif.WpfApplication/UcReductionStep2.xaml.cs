using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.Infrastructures.Algorithm.Models;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.ReductionSteps;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Algorithm;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferesdCourses;
using Tataiee.Harif.WpfApplication;
using Tataiee.Harif.WpfApplication.Infrastructures.Curriculum.Curriculums;
using System.Threading;
using System.IO;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.TopologicalSort;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcReductionStep2.xaml
    /// </summary>
    public partial class UcReductionStep2 : UserControl
    {

        bool allowUserInteraction = false;

        Button selectedButton = null;

        int minUnits = 12;

        int currentMustUnits = 0;

        int maxUnits = 24;

        int termNumber = 1;

        int timeoutMs = 120;

        bool capacityFiltering = false;

        bool exampCollideChecking = false;

        Tataiee.Harif.Infrastructures.GeneralEnums.Gender gender = Tataiee.Harif.Infrastructures.GeneralEnums.Gender.MALE;

        List<Card> cards = new List<Card>();

        private MainCurriculum mainCurriculum;

        //main list of offered courses
        readonly List<OfferedCourse> offeredCourses = new List<OfferedCourse>();
        //main list of offred course rows
        readonly List<OfferedCourseRow> offeredCourseRows = new List<OfferedCourseRow>();


        List<OfferedCourse> greenCourses = new List<OfferedCourse>();


        public UcReductionStep2()
        {

        }

        #region Initialization
        public async Task RunAfterCreatedAsync()
        {
            try
            {

                await Task.Run(async () =>
                {
                    await Dispatcher.InvokeAsync(() =>
                    {
                        InitializeComponent();
                    });

                    //Properties.Settings.Default.Reload();

                    //setting
                    if (Properties.Settings.Default.CurrentTermNumber > 0)
                        termNumber = Properties.Settings.Default.CurrentTermNumber;

                    gender = Properties.Settings.Default.Gender == 'm' ? Tataiee.Harif.Infrastructures.GeneralEnums.Gender.MALE : Tataiee.Harif.Infrastructures.GeneralEnums.Gender.FEMALE;

                    if (Properties.Settings.Default.MinUnits > 0)
                        minUnits = Properties.Settings.Default.MinUnits;

                    if (Properties.Settings.Default.MinUnits <= Properties.Settings.Default.MaxUnits && Properties.Settings.Default.MaxUnits > 0)
                        maxUnits = Properties.Settings.Default.MaxUnits;

                    if (Properties.Settings.Default.TimeoutForReductionStep2ms >= 120)
                        timeoutMs = Properties.Settings.Default.TimeoutForReductionStep2ms;

                    capacityFiltering = Properties.Settings.Default.CapacityFiltering;

                    exampCollideChecking = Properties.Settings.Default.ExamCollideChecking;

                    //end setting

                    mainCurriculum = StudentHistoryServiceProvider.CreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName);


                    int CODE_LEN = 7;


                    //load offered course row in memory
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.GoalVersionOfferedCoursesRowDirectory + DirectoryManager.GoalVersionOfferedCoursesRowSavedName, out List<GoalVersionOfferedCoursesRow> goalVersionOfferedCourseRows);

                    //perform reduction step 1 and get courses list after reduced
                    var coursesListAfterReductionStep1 = ReductionStep1.Reduce(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName
                        , termNumber);


                    //assign offeredCourseRows to the output of ReductionStep2 courses List                     
                    if (capacityFiltering)
                    {
                        goalVersionOfferedCourseRows = ReductionStep2.Reduce(coursesListAfterReductionStep1, goalVersionOfferedCourseRows, gender)
                        .Where(r => r.Capacity - r.Registered > 0).ToList();
                    }
                    else
                    {
                        goalVersionOfferedCourseRows = ReductionStep2.Reduce(coursesListAfterReductionStep1, goalVersionOfferedCourseRows, gender);
                    }

                    CODE_LEN = coursesListAfterReductionStep1[0].CodeInDesUni.Length;

                    //again group reduced offered course rows 
                    var coursesGroups = (from c in goalVersionOfferedCourseRows
                                         group c by c.Id.Substring(0, CODE_LEN)).ToList();

                    //--------

                    //we can add another reduction step to reduce more if possible but now we do not.
                    //---------



                    //fill main offeredCourses and offeredCourseRows lists
                    int i = 0;
                    int j = 0;
                    foreach (var course in coursesGroups)
                    {
                        var c = coursesListAfterReductionStep1.FirstOrDefault(c1 => c1.CodeInDesUni == course.Key);
                        if (c != null)
                        {
                            OfferedCourse oc = new OfferedCourse(c, i++, ReductionStep2ColorStatus.WHITE);
                            foreach (var row in course)
                            {
                                OfferedCourseRow ocr = new OfferedCourseRow(row, ReductionStep2ColorStatus.WHITE, j++, oc);
                                oc.OfferedCourseRows.Add(ocr);

                                cards.Add(null);
                                offeredCourseRows.Add(ocr);
                            }

                            offeredCourses.Add(oc);

                        }
                    }

                    if (Properties.Settings.Default.ReductionStep2MustBeLoad)
                    {

                        FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.ReductionStep2SavedStatus + DirectoryManager.SaveColorOfferedCourses, out List<SaveColorObjectModel> saveColorOfferedCourses);
                        FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.ReductionStep2SavedStatus + DirectoryManager.SaveColorOfferedCourseRows, out List<SaveColorObjectModel> saveColorOfferedCourseRows);


                        saveColorOfferedCourses.ForEach(scoc =>
                        {
                            offeredCourses[scoc.CorrespondingIdInSourceList].Color = scoc.Color;
                        });

                        saveColorOfferedCourseRows.ForEach(scocr =>
                        {
                            offeredCourseRows[scocr.CorrespondingIdInSourceList].Color = scocr.Color;
                        });

                    }

                    //fill CollisionList
                    /*
                    for (int w = 0; w < offeredCourseRows.Count; w++)
                    {
                        //offeredCourseRows[w].CollisionList.ad
                        for (int t = 0; t < goalVersionOfferedCourseRows.Count; t++)
                        {
                            if (w == t) continue;
                            if (OfferedCoursesServiceProvider.DoTheyCollide(goalVersionOfferedCourseRows[w].TimeAndSitesAndExam.TimeAndSites, goalVersionOfferedCourseRows[t].TimeAndSitesAndExam.TimeAndSites))
                                offeredCourseRows[w].OfferedCourseRowCollisionList.Add(t);

                        }

                    }
                    */


                    //create and fill courses navigation button in right side
                    await Dispatcher.InvokeAsync(() =>
                    {

                        stackPanelRightSide.Children.Clear();
                        Button button1 = null;
                        for (int m = 0; m < offeredCourses.Count; m++)
                        {

                            Badged badged = new Badged
                            {
                                Badge = offeredCourses[m].OfferedCourseCode,
                                Margin = new Thickness(5),
                                Name = "bdg" + offeredCourses[m].CourseId
                            };

                            Button button = new Button
                            {
                                Content = new TextBlock()
                                {
                                    Text = offeredCourses[m].OfferedCourseName,
                                    TextAlignment = TextAlignment.Center,
                                    TextWrapping = TextWrapping.Wrap
                                },
                                Name = "btn" + m.ToString(),
                                Width = 250,
                                Height = Double.NaN,
                                Padding = new Thickness(5),

                                Background = Brushes.Transparent
                            };

                            button.Click += btnCourseNavigation_Click;
                            badged.Content = button;

                            if (m == 0)
                            {
                                button1 = button;
                            }
                            stackPanelRightSide.Children.Add(badged);
                        }
                        selectedButton = button1;

                        allowUserInteraction = true;
                        btnCourseNavigation_Click(button1, null);
                    });


                });

            }
            catch
            {

            }
        }
        #endregion


        //validation

        //row
        private async void Card_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            Card card = (Card)sender;

            string[] splitedStr = card.Name.Substring(4).Split('_');
            int rowId = int.Parse(splitedStr[1]);
            int courseId = int.Parse(splitedStr[0]);

            var offeredCourseRow = offeredCourseRows[rowId];


            if (offeredCourseRow.Color == ReductionStep2ColorStatus.RED)
            {
                //validation
                bool output = await IsValidAsync(offeredCourseRow.OfferedCourse, ReductionStepAction.WHITE_ONE_RED_ROW, offeredCourseRow);
                if (!output)
                {
                    allowUserInteraction = true;
                    return;
                }

                SetCardBackgroundColor(card, ReductionStep2ColorStatus.WHITE);
                offeredCourseRow.Color = ReductionStep2ColorStatus.WHITE;
            }
            else if (offeredCourseRow.Color == ReductionStep2ColorStatus.WHITE)
            {
                //validation
                bool output = await IsValidAsync(offeredCourseRow.OfferedCourse, ReductionStepAction.RED_ONE_WHITE_ROW, offeredCourseRow);
                if (!output)
                {
                    allowUserInteraction = true;
                    return;
                }

                SetCardBackgroundColor(card, ReductionStep2ColorStatus.RED);
                offeredCourseRow.Color = ReductionStep2ColorStatus.RED;
            }
            else
                throw new Exception();

            allowUserInteraction = true;

        }

        private async void btnAllRowsWhite_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            if (selectedButton == null)
            {
                allowUserInteraction = true;
                return;
            }

            int offeredCoursesId = int.Parse(selectedButton.Name.Substring(3));

            OfferedCourse offeredCourse = offeredCourses[offeredCoursesId];

            //validation
            bool output = await IsValidAsync(offeredCourse, ReductionStepAction.WHITE_ALL_COURSES_ROWS);
            if (!output)
            {
                allowUserInteraction = true;
                return;
            }

            foreach (var row in offeredCourse.OfferedCourseRows)
            {
                if (row.Color != ReductionStep2ColorStatus.WHITE)
                {
                    SetCardBackgroundColor(/*row.Card as Card*/ cards[row.RowId], ReductionStep2ColorStatus.WHITE);
                    row.Color = ReductionStep2ColorStatus.WHITE;
                }
            }

            allowUserInteraction = true;

        }

        private async void btnAllRowsRed_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            int offeredCoursesId = int.Parse(selectedButton.Name.Substring(3));

            OfferedCourse offeredCourse = offeredCourses[offeredCoursesId];

            //validation
            bool output = await IsValidAsync(offeredCourse, ReductionStepAction.RED_ALL_COURSES_ROWS);
            if (!output)
            {
                allowUserInteraction = true;
                return;
            }

            foreach (var row in offeredCourse.OfferedCourseRows)
            {
                if (row.Color != ReductionStep2ColorStatus.RED)
                {
                    SetCardBackgroundColor(/*(Card)row.Card*/cards[row.RowId], ReductionStep2ColorStatus.RED);
                    row.Color = ReductionStep2ColorStatus.RED;
                }
            }

            allowUserInteraction = true;
        }

        //btn course must be take
        private async void btnMustBeTake_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            if (selectedButton == null)
            {
                allowUserInteraction = true;
                return;
            }

            int x = int.Parse(selectedButton.Name.Substring(3));
            var selectedCourse = offeredCourses[x];

            if (selectedCourse.Color == ReductionStep2ColorStatus.WHITE)
            {
                //validation
                bool output = await IsValidAsync(selectedCourse, ReductionStepAction.CHECK_COURSE_MUST_BE_TAKE);
                if (!output)
                {
                    allowUserInteraction = true;
                    return;
                }

                selectedCourse.Color = ReductionStep2ColorStatus.Green;

                //green
                SetButtonBackgroundColor(btnMustBeTake, ReductionStep2ColorStatus.Green);

                greenCourses.Add(selectedCourse);

                currentMustUnits += selectedCourse.Course.Units;


            }
            else if (selectedCourse.Color == ReductionStep2ColorStatus.Green)
            {
                //validation
                bool output = await IsValidAsync(selectedCourse, ReductionStepAction.UNCHECK_COURSE_MUST_BE_TAKE);
                if (!output)
                {
                    allowUserInteraction = true;
                    return;
                }

                selectedCourse.Color = ReductionStep2ColorStatus.WHITE;

                SetButtonBackgroundColor(btnMustBeTake, ReductionStep2ColorStatus.WHITE);

                greenCourses.Remove(selectedCourse);

                currentMustUnits -= selectedCourse.Course.Units;

            }
            else
                throw new Exception();

            allowUserInteraction = true;
        }


        private Task<bool> IsValidAsync(OfferedCourse offeredCourse, ReductionStepAction action, OfferedCourseRow offeredCourseRow = null)
        {
            return Task.Run<bool>(() => IsValid(offeredCourse, action, offeredCourseRow));
        }

        private bool IsValid(OfferedCourse offeredCourse, ReductionStepAction action, OfferedCourseRow offeredCourseRow = null)
        {
            if (action == ReductionStepAction.WHITE_ONE_RED_ROW)
            {
                return true;
            }
            else if (action == ReductionStepAction.WHITE_ALL_COURSES_ROWS)
            {
                return true;
            }
            else if (action == ReductionStepAction.RED_ALL_COURSES_ROWS)
            {
                if (offeredCourse.Color == ReductionStep2ColorStatus.Green)
                {
                    return false;
                }
                else if (offeredCourse.Color == ReductionStep2ColorStatus.WHITE)
                {
                    return true;
                }
                else throw new Exception();
            }
            else if (action == ReductionStepAction.UNCHECK_COURSE_MUST_BE_TAKE)
            {
                List<int> lst = new List<int>();
                foreach (var o in greenCourses)
                    if (o != offeredCourse)
                        lst.Add(o.Course.Id);
                //is valid state must be check
                return MainCurriculumSateValidator.IsValidState(mainCurriculum, lst);
            }
            else if (action == ReductionStepAction.RED_ONE_WHITE_ROW)
            {
                if (offeredCourse.Color == ReductionStep2ColorStatus.WHITE)
                {
                    return true;
                }
                else if (offeredCourse.Color == ReductionStep2ColorStatus.Green)
                {

                    //int x = 0;
                    //for (int a = 0; a < offeredCourse.OfferedCourseRows.Count; a++)
                    //{
                    //    if (offeredCourse.OfferedCourseRows[a].Color == ReduceStep2ColorStatus.WHITE)
                    //    {
                    //        x++;
                    //        if (x > 1)
                    //            break;
                    //    }
                    //}
                    //if (x < 2) return false;

                    //if (greenCourses.Count == 1)
                    //    return true;

                    //temorary change the actual current value
                    offeredCourseRow.Color = ReductionStep2ColorStatus.RED;

                    List<Box> boxes = new List<Box>
                    {
                        ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(offeredCourse)
                    };

                    //restore actual value
                    offeredCourseRow.Color = ReductionStep2ColorStatus.WHITE;

                    foreach (var item in greenCourses)
                    {
                        if (item != offeredCourse)
                            boxes.Add(ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(item));
                    }

                    List<Box> res = null;
                    var task = Task.Run(() => ReductionStep2ServiceProvider.Validate(boxes, exampCollideChecking));
                    if (task.Wait(TimeSpan.FromMilliseconds(timeoutMs)))
                        res = task.Result;
                    else
                    {
                        res = null;
                    }



                    if (res == null) return false;
                    return true;

                }
                else
                    throw new Exception();
            }
            else if (action == ReductionStepAction.CHECK_COURSE_MUST_BE_TAKE)
            {
                if (offeredCourse.Course.Units + currentMustUnits > maxUnits)
                {
                    return false;
                }

                List<int> lst = new List<int>();
                foreach (var o in greenCourses)
                    lst.Add(o.Course.Id);
                lst.Add(offeredCourse.Course.Id);
                //is valid state must be check
                bool output = MainCurriculumSateValidator.IsValidState(mainCurriculum, lst);
                if (!output) return false;

                output = false;
                for (int a = 0; a < offeredCourse.OfferedCourseRows.Count; a++)
                {
                    if (offeredCourse.OfferedCourseRows[a].Color == ReductionStep2ColorStatus.WHITE)
                    {
                        output = true;
                        break;
                    }
                }
                if (!output) return false;

                //if (greenCourses.Count == 0)
                // return true;

                Box b1 = ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(offeredCourse);

                List<Box> boxes = new List<Box>
                {
                    b1
                };
                foreach (var item in greenCourses)
                {
                    boxes.Add(ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(item));
                }

                List<Box> res = null;
                var task = Task.Run(() => ReductionStep2ServiceProvider.Validate(boxes, exampCollideChecking));
                if (task.Wait(TimeSpan.FromMilliseconds(timeoutMs)))
                    res = task.Result;
                else
                {
                    res = null;
                }

                //res = Validate(boxes);

                if (res == null) return false;

                //if (res[0].Rows[0].Columns.Count >= 6)
                //{
                //    List<GoalVersionOfferedCoursesRow> lstX = new List<GoalVersionOfferedCoursesRow>();

                //    res[0].Rows.ForEach(r =>
                //    {
                //        lstX.Clear();
                //        int units = 0;
                //        r.Columns.ForEach(c =>
                //        {
                //            lstX.Add(c.GoalVersionOfferedCourseRow);
                //            units += c.GoalVersionOfferedCourseRow.Units;
                //        });
                //        OfferedWeeklyProgram newowp = new OfferedWeeklyProgram();
                //        newowp.DataSource = lstX;
                //        newowp.Description = "Hello World!" + r.Columns[0].Color;
                //        newowp.Score = 123 + new Random().Next(10);
                //        newowp.TermNumber = new Random().Next(1, 12);
                //        newowp.NumberOfUnits = units;
                //        newowp.UserScore = 0;
                //        FileServiceProvider.SerializeToXmlFile(DirectoryManager.LastAlgorithmExeOutputs + Guid.NewGuid().ToString()+".xml", newowp);
                //    });

                //    //res[0].Rows[0].Columns.ForEach(c =>
                //    //{
                //    //    lstX.Add(c.GoalVersionOfferedCourseRow);
                //    //});                    
                //    //    FileServiceProvider.SerializeToXmlFile(@"Data\ReductionSteps\MyTestFile.xml", lstX);
                //    //}
                //    //if res!=null we can use possible responses by this way
                //    //Box mainbox=res[0];

                //    return true;
                //}    

                return true;
            }

            throw new Exception();
            //return false;
        }

        #region Navigation
        //navigate to another course
        private async void btnCourseNavigation_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            Button btn = (Button)sender;

            selectedButton.Background = Brushes.White;

            selectedButton = btn;

            selectedButton.SetResourceReference(Button.BackgroundProperty, "PrimaryHueMidBrush");

            int offeredCoursesId = int.Parse(btn.Name.Substring(3));

            OfferedCourse offeredCourse = offeredCourses[offeredCoursesId];


            SetButtonBackgroundColor(btnMustBeTake, offeredCourse.Color);
            await FillRowsOfCourseGraphicallyAsync(stackPanelCenterContent, offeredCourse);

            allowUserInteraction = true;

        }
        #endregion
        #region Graphic Rendering
        private void SetCardBackgroundColor(Card card, ReductionStep2ColorStatus rowColor)
        {

            if (rowColor == ReductionStep2ColorStatus.Grey)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#d0cdcd");
                brush.Freeze();

                card.Background = brush;
                card.Foreground = Brushes.Black;

            }
            else if (rowColor == ReductionStep2ColorStatus.RED)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#f0513c");
                brush.Freeze();
                card.Background = brush;
                card.Foreground = Brushes.White;
            }
            else if (rowColor == ReductionStep2ColorStatus.WHITE)//default color
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#ffffff");
                brush.Freeze();
                card.Background = brush;
                card.Foreground = Brushes.Black;
            }
            else if (rowColor == ReductionStep2ColorStatus.Green)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#8ee269");
                brush.Freeze();
                card.Background = brush;
                card.Foreground = Brushes.Black;
            }
        }
        private void SetButtonBackgroundColor(Button btn, ReductionStep2ColorStatus rowColor)
        {
            if (rowColor == ReductionStep2ColorStatus.Grey)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#d0cdcd");
                brush.Freeze();

                btn.Background = brush;
                btn.Foreground = Brushes.Black;

            }
            else if (rowColor == ReductionStep2ColorStatus.RED)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#f0513c");
                brush.Freeze();
                btn.Background = brush;
                btn.Foreground = Brushes.White;
            }
            else if (rowColor == ReductionStep2ColorStatus.WHITE)//default color
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#ffffff");
                brush.Freeze();
                btn.Background = brush;
                btn.Foreground = Brushes.Black;
                btn.Content = null;
            }
            else if (rowColor == ReductionStep2ColorStatus.Green)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#8ee269");
                brush.Freeze();
                btn.Background = brush;
                btn.Foreground = Brushes.Black;
                btn.Content = new PackIcon { Kind = PackIconKind.Check };
            }
        }

        private async Task FillRowsOfCourseGraphicallyAsync(StackPanel uiElement, OfferedCourse offeredCourse)
        {
            uiElement.Children.Clear();

            await Task.Run(async () =>
            {
                foreach (var row in offeredCourse.OfferedCourseRows)
                {
                    await Dispatcher.InvokeAsync(() =>
                    {
                        /* row.Card*/
                        cards[row.RowId] = AddNewRowToStackPanel(uiElement, row.RowId.ToString(), row.ProfessorName, row.RemainedCapacity.ToString(), row.TimeAndSiteAndExamRawString, row.Description, offeredCourse.CourseId.ToString(), row.Color);
                        //AddNewSeparatorToStackPanel(uiElement);
                    });
                }
            });


        }

        private Card AddNewRowToStackPanel(StackPanel originStackPanel, string rowId, string professorName, string remainedCapacity, string timeAndSiteAndExamRawString, string Description, string parentCourseId, ReductionStep2ColorStatus rowColor)
        {
            Card card = new Card
            {
                Cursor = Cursors.Hand
            };

            SetCardBackgroundColor(card, rowColor);
            //v.i
            card.Name = "card" + parentCourseId + "_" + rowId;

            card.MouseDoubleClick += Card_MouseDoubleClick;
            card.Margin = new Thickness(5);
            originStackPanel.Children.Add(card);

            Grid gridRow = new Grid();
            card.Content = gridRow;

            gridRow.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });//id
            gridRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });//professorName
            gridRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });//remain capacity
            gridRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(225) });//time and ...
            gridRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(370) });//description
            //AddNewComboboxToGrid(gridRow, 0, 0);
            AddNewTextBlockToGrid(gridRow, rowId, 0, 0);
            AddNewTextBlockToGrid(gridRow, professorName, 0, 1);
            AddNewTextBlockToGrid(gridRow, remainedCapacity, 0, 2);
            AddNewTextBlockToGrid(gridRow, timeAndSiteAndExamRawString, 0, 3);
            AddNewTextBlockToGrid(gridRow, Description, 0, 4);

            return card;
        }

        private void AddNewTextBlockToGrid(Grid originGrid, string text, int row = 0, int clm = 0)
        {
            TextBlock txtBlock = new TextBlock
            {
                Margin = new Thickness(2),
                Text = text,
                TextWrapping = TextWrapping.Wrap,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            txtBlock.SetValue(Grid.RowProperty, row);
            txtBlock.SetValue(Grid.ColumnProperty, clm);
            originGrid.Children.Add(txtBlock);
        }

        private void AddNewSeparatorToStackPanel(StackPanel originStackPanel)
        {
            Separator separator = new Separator();
            originStackPanel.Children.Add(separator);
        }
        #endregion

        private async void btnTimeFilter_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            btnTimeFilter.IsEnabled = false;
            List<TimeFilteringModel> tfms = new List<TimeFilteringModel>();
            bool succ = false;
            try
            {
                bool[] days = new bool[7];

                ReductionStep2ColorStatus color = rdbRedColor.IsChecked == true ? ReductionStep2ColorStatus.RED : ReductionStep2ColorStatus.WHITE;

                #region r1

                if (Day0.IsChecked == true)
                    days[0] = true;
                if (Day1.IsChecked == true)
                    days[1] = true;
                if (Day2.IsChecked == true)
                    days[2] = true;
                if (Day3.IsChecked == true)
                    days[3] = true;
                if (Day4.IsChecked == true)
                    days[4] = true;
                if (Day5.IsChecked == true)
                    days[5] = true;
                if (Day6.IsChecked == true)
                    days[6] = true;

                string[] tFrom = txtStartTime.Text.Split(':');
                string[] tTo = txtFinishTime.Text.Split(':');

                int hStart;
                int mStart;

                int hFinish;
                int mFinish;

                if (!int.TryParse(tFrom[0], out hStart))
                {
                    throw new Exception();
                }
                if (!int.TryParse(tFrom[1], out mStart))
                {
                    throw new Exception();
                }


                if (!int.TryParse(tTo[0], out hFinish))
                {
                    throw new Exception();
                }
                if (!int.TryParse(tTo[1], out mFinish))
                {
                    throw new Exception();
                }

                #endregion


                List<TimeAndSite> ts = new List<TimeAndSite>();

                await Task.Run(() =>
                {

                    for (int i = 0; i < days.Length; i++)
                    {
                        if (days[i] == true)
                        {
                            TimeAndSite time = new TimeAndSite
                            {
                                StartTime = new LocalTime() { Hour = hStart, Minute = mStart, },
                                FinishTime = new LocalTime() { Hour = hFinish, Minute = mFinish, },
                                Day = (Harif.Infrastructures.GeneralEnums.Day)i
                            };
                            ts.Add(time);
                        }
                    }




                    foreach (var ofRow in offeredCourseRows)
                    {
                        if (ofRow.Color != color && OfferedCoursesServiceProvider.DoTheyCollide(ofRow.GoalVersionOfferedCourseRow.TimeAndSitesAndExam.TimeAndSites, ts))
                        {
                            TimeFilteringModel model = new TimeFilteringModel
                            {
                                Row = ofRow
                            };
                            model.TempOriginColor = model.Row.Color;
                            ofRow.Color = color;
                            tfms.Add(model);
                        }
                    }

                    if (greenCourses.Count > 0)
                    {
                        List<Box> boxes = new List<Box>();

                        foreach (var item in greenCourses)
                        {
                            boxes.Add(ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(item));
                        }

                        List<Box> res = null;
                        var task = Task.Run(() => ReductionStep2ServiceProvider.Validate(boxes, exampCollideChecking));
                        if (task.Wait(TimeSpan.FromMilliseconds(timeoutMs)))
                            res = task.Result;
                        else
                        {
                            res = null;
                        }

                        if (res == null)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            //is ok
                        }
                    }
                    else
                    {
                        //is ok
                    }

                    succ = true;

                });
            }
            catch
            {

                foreach (var tfm in tfms)
                {
                    tfm.Row.Color = tfm.TempOriginColor;
                }
                lblMsgActionPerform.Foreground = Brushes.Red;
                lblMsgActionPerform.Content = "خطایی رخ داده است";
            }
            finally
            {
                btnTimeFilter.IsEnabled = true;
                allowUserInteraction = true;

                if (succ)
                {
                    lblMsgActionPerform.Foreground = Brushes.DarkGreen;
                    lblMsgActionPerform.Content = "فیلتر با موفقیت اعمال شد";

                    btnCourseNavigation_Click(selectedButton, null);
                }
            }



        }



        private void btnShowLastAlgorithmOutputs_Click(object sender, RoutedEventArgs e)
        {
            if (btnRunAlgorithm.IsEnabled)
            {
                new LastAlgorithmOutputShowerWindow().Show();
            }
        }

        private async void btnRunAlgorithm_Click(object sender, RoutedEventArgs e)
        {

            btnRunAlgorithm.IsEnabled = false;
            if (!allowUserInteraction) return;
            allowUserInteraction = false;

            try
            {


                AnimateStatusObjectModel model = new AnimateStatusObjectModel();

                Infrastructures.Algorithm.MainAlgorithm mainAlgorithm = new Infrastructures.Algorithm.MainAlgorithm(15);

                Task.Run(() => { mainAlgorithm.Run(offeredCourses, mainCurriculum, minUnits, maxUnits, exampCollideChecking, Properties.Settings.Default.AlgorithmMaxProcessingTimeMS, model); });


                await AlgorithmAnimation.Animate(this, canvasAlgorithmMsg, Properties.Settings.Default.AlgorithmAnimationEffectStatus, model);

                Directory.EnumerateFiles(DirectoryManager.LastAlgorithmExeOutputs).ToList().ForEach(c =>
                {
                    File.Delete(c);
                });

                for (int i = 0; i < mainAlgorithm.ChoosedWeeklyProgram.Count; i++)
                {
                    var p = mainAlgorithm.ChoosedWeeklyProgram[i];

                    OfferedWeeklyProgram newProgram = new OfferedWeeklyProgram();
                    newProgram.DataSource = new List<GoalVersionOfferedCoursesRow>();
                    int units = 0;
                    DfsTopologicalSortAlgorithm.DfsTopologicalSort(p.WeeklyProgram.Columns).ForEach(c =>
                    {
                        newProgram.DataSource.Add(c.GoalVersionOfferedCourseRow);
                        units += c.OfferedCourse.Course.Units;
                    });
                    newProgram.Description = "";
                    newProgram.NumberOfUnits = units;
                    newProgram.UserScore = 0;
                    newProgram.TermNumber = termNumber;
                    newProgram.Score = p.WeeklyProgramScore;

                    //string name = Guid.NewGuid().ToString();
                    FileServiceProvider.SerializeToXmlFile(DirectoryManager.LastAlgorithmExeOutputs + "p" + i.ToString() + ".xml", newProgram);
                    Thread.Sleep(10);
                }
            }
            catch { }

            allowUserInteraction = true;
            btnRunAlgorithm.IsEnabled = true;
        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!allowUserInteraction) return;
            allowUserInteraction = false;
            try
            {
                List<SaveColorObjectModel> saveColorOfferedCourses;
                List<SaveColorObjectModel> saveColorOfferedCourseRows;

                saveColorOfferedCourses = new List<SaveColorObjectModel>();
                saveColorOfferedCourseRows = new List<SaveColorObjectModel>();

                offeredCourses.ForEach(oc =>
                {
                    saveColorOfferedCourses.Add(new SaveColorObjectModel { CorrespondingIdInSourceList = oc.CourseId, Color = oc.Color });
                });
                offeredCourseRows.ForEach(ocr =>
                {
                    saveColorOfferedCourseRows.Add(new SaveColorObjectModel { CorrespondingIdInSourceList = ocr.RowId, Color = ocr.Color });
                });

                FileServiceProvider.SerializeToXmlFile(DirectoryManager.ReductionStep2SavedStatus + DirectoryManager.SaveColorOfferedCourses, saveColorOfferedCourses);
                FileServiceProvider.SerializeToXmlFile(DirectoryManager.ReductionStep2SavedStatus + DirectoryManager.SaveColorOfferedCourseRows, saveColorOfferedCourseRows);

                Properties.Settings.Default.ReductionStep2MustBeLoad = true;
                Properties.Settings.Default.Save();
            }
            catch
            {

            }

            allowUserInteraction = true;
        }
    }
}

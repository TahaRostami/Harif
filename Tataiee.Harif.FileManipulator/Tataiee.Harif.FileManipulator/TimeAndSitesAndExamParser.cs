using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.FileManipulator.Models;

namespace Tataiee.Harif.FileManipulator
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeAndSitesAndExamParser
    {
        private List<string> tokens;

        int current;

        private TimeAndSiteAndExams timeAndSiteAndExams;

        private int GetCurrentIndex() => current;
        private int GetNextIndex() => current + 1;
        private int GetPrevIndex() => current - 1;

        private int GoToNextIndex() => ++current;
        private int GoToPrevIndex() => --current;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public TimeAndSiteAndExams Parse(List<string> tokens)
        {
            current = 0;
            this.tokens = tokens;
            timeAndSiteAndExams = new TimeAndSiteAndExams();

            bool valid = Program();

            if (valid)
                return timeAndSiteAndExams;
            else
                throw new Exception();
        }

        private bool Program()
        {
            if (tokens[current] == "درس")
            {
                current++;
                if (tokens[current] == "(")
                {
                    current++;
                    if (tokens[current] == "ت" || tokens[current] == "ع")
                    {
                        current++;
                        if (tokens[current] == ")")
                        {
                            current++;
                            if (tokens[current] == ":")
                            {
                                current++;

                                int minuteStartTime;
                                int hourStartTime;
                                int minuteFinishTime;
                                int hourFinishTime;
                                string site = string.Empty;
                                Day day = Day.NAN;
                                if (tokens[current] == "شنبه" || tokens[current] == "یک شنبه" || tokens[current] == "دو شنبه" || tokens[current] == "سه شنبه" ||
                                    tokens[current] == "چهار شنبه" || tokens[current] == "پنج شنبه" || tokens[current] == "جمعه")
                                {
                                    current++;
                                    if (tokens[current - 1] == "شنبه")
                                    {
                                        day = Day.SATURDAY;
                                    }
                                    else if (tokens[current - 1] == "یک شنبه")
                                    {
                                        day = Day.SUNDAY;
                                    }
                                    if (tokens[current - 1] == "دو شنبه")
                                    {
                                        day = Day.MONDAY;
                                    }
                                    if (tokens[current - 1] == "سه شنبه")
                                    {
                                        day = Day.TUESDAY;
                                    }
                                    if (tokens[current - 1] == "چهار شنبه")
                                    {
                                        day = Day.WEDNESDAY;
                                    }
                                    if (tokens[current - 1] == "پنج شنبه")
                                    {
                                        day = Day.THURSDAY;
                                    }
                                    if (tokens[current - 1] == "جمعه")
                                    {
                                        day = Day.FRIDAY;
                                    }

                                    if (int.TryParse(tokens[current], out hourStartTime) && tokens[current].Length == 2)
                                    {
                                        current++;
                                        if (tokens[current] == ":")
                                        {
                                            current++;

                                            if (int.TryParse(tokens[current], out minuteStartTime) && tokens[current].Length == 2)
                                            {
                                                current++;
                                                if (tokens[current] == "-")
                                                {
                                                    current++;

                                                    if (int.TryParse(tokens[current], out hourFinishTime) && tokens[current].Length == 2)
                                                    {
                                                        current++;

                                                        if (tokens[current] == ":")
                                                        {
                                                            current++;
                                                            if (int.TryParse(tokens[current], out minuteFinishTime) && tokens[current].Length == 2)
                                                            {
                                                                current++;

                                                                if (tokens[current] == "مکان")
                                                                {
                                                                    current++;
                                                                    if (tokens[current] == ":")
                                                                    {
                                                                        current++;

                                                                        site = tokens[current];

                                                                        current++;
                                                                        if (tokens[current] == "#")
                                                                        {
                                                                            current++;
                                                                            //valid
                                                                            TimeAndSite timeAndSite = new TimeAndSite();
                                                                            timeAndSite.Day = day;
                                                                            timeAndSite.Site = new LocalSite() { RawStringSiteValue = site };
                                                                            timeAndSite.StartTime = new LocalTime()
                                                                            {
                                                                                Minute = minuteStartTime,
                                                                                Hour = hourStartTime
                                                                            };
                                                                            timeAndSite.FinishTime = new LocalTime()
                                                                            {
                                                                                Minute = minuteFinishTime,
                                                                                Hour = hourFinishTime
                                                                            };
                                                                            timeAndSiteAndExams.TimeAndSites.Add(timeAndSite);
                                                                            return Program();
                                                                        }
                                                                    }
                                                                }
                                                                else if (tokens[current] == "#")
                                                                {
                                                                    current++;
                                                                    //valid
                                                                    TimeAndSite timeAndSite = new TimeAndSite();
                                                                    timeAndSite.Day = day;
                                                                    timeAndSite.Site = new LocalSite() { RawStringSiteValue = site };
                                                                    timeAndSite.StartTime = new LocalTime()
                                                                    {
                                                                        Minute = minuteStartTime,
                                                                        Hour = hourStartTime
                                                                    };
                                                                    timeAndSite.FinishTime = new LocalTime()
                                                                    {
                                                                        Minute = minuteFinishTime,
                                                                        Hour = hourFinishTime
                                                                    };
                                                                    timeAndSiteAndExams.TimeAndSites.Add(timeAndSite);
                                                                    return Program();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (tokens[current] == "امتحان")
            {
                current++;
                if (tokens[current] == "(")
                {
                    current++;

                    int year;
                    int month;
                    int day;

                    int hourStartTime;
                    int minuteStartTime;
                    int hourFinishTime;
                    int minuteFinishTime;

                    if (int.TryParse(tokens[current], out year) && tokens[current].Length == 4)
                    {
                        current++;
                        if (tokens[current] == ".")
                        {
                            current++;
                            if (int.TryParse(tokens[current], out month) && tokens[current].Length == 2)
                            {
                                current++;
                                if (tokens[current] == ".")
                                {
                                    current++;
                                    if (int.TryParse(tokens[current], out day) && tokens[current].Length == 2)
                                    {
                                        current++;
                                        if (tokens[current] == ")")
                                        {
                                            current++;
                                            if (tokens[current] == "ساعت")
                                            {
                                                current++;
                                                if (tokens[current] == ":")
                                                {
                                                    current++;
                                                    if (int.TryParse(tokens[current], out hourStartTime) && tokens[current].Length == 2)
                                                    {
                                                        current++;
                                                        if (tokens[current] == ":")
                                                        {
                                                            current++;
                                                            if (int.TryParse(tokens[current], out minuteStartTime) && tokens[current].Length == 2)
                                                            {
                                                                current++;
                                                                if (tokens[current] == "-")
                                                                {
                                                                    current++;
                                                                    if (int.TryParse(tokens[current], out hourFinishTime) && tokens[current].Length == 2)
                                                                    {
                                                                        current++;
                                                                        if (tokens[current] == ":")
                                                                        {
                                                                            current++;
                                                                            if (int.TryParse(tokens[current], out minuteFinishTime) && tokens[current].Length == 2)
                                                                            {
                                                                                current++;
                                                                                if (tokens[current] == "#")
                                                                                {
                                                                                    current++;
                                                                                    //valid
                                                                                    timeAndSiteAndExams.Exam = new Exam();
                                                                                    timeAndSiteAndExams.Exam.StartTime = new LocalTime()
                                                                                    {
                                                                                        Minute = minuteStartTime,
                                                                                        Hour = hourStartTime
                                                                                    };
                                                                                    timeAndSiteAndExams.Exam.FinishTime = new LocalTime()
                                                                                    {
                                                                                        Minute = minuteFinishTime,
                                                                                        Hour = hourFinishTime
                                                                                    };
                                                                                    timeAndSiteAndExams.Exam.Date = new LocalDate()
                                                                                    {
                                                                                        Day = day,
                                                                                        Month = month,
                                                                                        Year = year
                                                                                    };
                                                                                    return Program();
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (tokens[current] == "$")//finish file
            {
                return true;
            }
            return false;
        }

    }
}

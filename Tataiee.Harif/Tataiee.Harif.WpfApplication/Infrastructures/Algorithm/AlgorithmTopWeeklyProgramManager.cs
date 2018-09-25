using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm
{
    public class AlgorithmTopWeeklyProgramManager
    {
        private static object _sync = new object();

        public int Count { get; private set; }
        private AlgorithmRowScoreObjectModel[] WeeklyPrograms;
        public AlgorithmTopWeeklyProgramManager(int r)
        {
            if (r < 1) throw new Exception();
            WeeklyPrograms = new AlgorithmRowScoreObjectModel[r];
            Count = 0;
        }
        public AlgorithmRowScoreObjectModel this[int i]
        {
            get { return WeeklyPrograms[i]; }
        }

        private AlgorithmRowScoreObjectModel Min()
        {
            return Count > 0 ? WeeklyPrograms[Count - 1] : null;
        }

        private bool IsEmpty()
        {
            return Count == 0;
        }

        public void Sort()
        {                              
            lock(_sync)
            {
                Array.Sort(WeeklyPrograms, delegate (AlgorithmRowScoreObjectModel m1,AlgorithmRowScoreObjectModel m2) {
                    return m2.WeeklyProgramScore.CompareTo(m1.WeeklyProgramScore);
                });
            }
        }

        private bool AddUpdate(AlgorithmRowScoreObjectModel newModel)
        {
            bool res = true;
            lock (_sync)
            {
                try
                {
                    if (Count < WeeklyPrograms.Length)
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            if (AlgorithmRowScoreObjectModel.Equal(newModel, WeeklyPrograms[i]))
                            {
                                res = false;
                                break;
                            }
                        }
                        if (res)
                        {
                            WeeklyPrograms[Count++] = newModel;
                        }
                    }
                    else
                    {
                        double min = double.MaxValue;
                        int minIndex = -1;

                        for (int i = 0; i < Count; i++)
                        {
                            if (WeeklyPrograms[i].WeeklyProgramScore < min)
                            {
                                min = WeeklyPrograms[i].WeeklyProgramScore;
                                minIndex = i;
                            }
                            if (AlgorithmRowScoreObjectModel.Equal(newModel, WeeklyPrograms[i]))
                            {
                                res = false;
                                break;
                            }
                        }
                        if (res)
                        {
                            if (newModel.WeeklyProgramScore > min)
                            {
                                WeeklyPrograms[minIndex] = newModel;
                            }
                        }
                    }
                }
                catch { }
            }

            return res;
        }


        public void AddUpdateRangeData(List<Row> rows)
        {
            foreach (var item in rows)
            {
                AlgorithmRowScoreObjectModel newModel = new AlgorithmRowScoreObjectModel();
                newModel.WeeklyProgram = item;
                newModel.WeeklyProgramScore = AlgorithmRowScoreObjectModel.CalculateWeeklyProgramScore(item.Columns);
                AddUpdate(newModel);
            }
        }
        public void Clear()
        {
            lock (_sync)
            {
                Count = 0;
            }
        }


    }
}

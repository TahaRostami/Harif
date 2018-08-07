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

        private bool AddUpdate(AlgorithmRowScoreObjectModel newModel)
        {
            bool res = true;
            lock (_sync)
            {
                try
                {
                    //AlgorithmRowScoreObjectModel.Compare(newModel, WeeklyPrograms[i]) > 0
                    if (Count == 0)
                    {
                        WeeklyPrograms[Count++] = newModel;
                    }
                    else if (Count < WeeklyPrograms.Length)
                    {
                        int x = Count;
                        for (int i = Count - 1; i >= 0; i--)
                        {
                            if (AlgorithmRowScoreObjectModel.Compare(newModel, WeeklyPrograms[i]) > 0)
                            {
                                x = i;
                            }
                            else if (AlgorithmRowScoreObjectModel.Equal(newModel, WeeklyPrograms[i]))
                            {
                                res = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (res)
                        {
                            for (int i = Count - 1; i >= x; i--)
                            {
                                WeeklyPrograms[i + 1] = WeeklyPrograms[i];
                            }
                            WeeklyPrograms[x] = newModel;
                            Count++;
                        }

                    }
                    else if (AlgorithmRowScoreObjectModel.Compare(newModel, WeeklyPrograms[Count - 1]) > 0)
                    {
                        int x = Count - 1;
                        for (int i = Count - 1 - 1; i >= 0; i--)
                        {
                            if (AlgorithmRowScoreObjectModel.Compare(newModel, WeeklyPrograms[i]) > 0)
                            {
                                x = i;
                            }
                            else if (AlgorithmRowScoreObjectModel.Equal(newModel, WeeklyPrograms[i]))
                            {
                                res = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (res)
                        {
                            for (int i = Count - 1 - 1; i >= x; i--)
                            {
                                WeeklyPrograms[i + 1] = WeeklyPrograms[i];
                            }
                            WeeklyPrograms[x] = newModel;                            
                        }
                    }

                }
                catch { }
            }

            return res;
            //throw new Exception();
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

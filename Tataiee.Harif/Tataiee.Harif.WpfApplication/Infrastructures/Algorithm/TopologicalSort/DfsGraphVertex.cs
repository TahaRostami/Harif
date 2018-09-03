using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.TopologicalSort
{

    public class DfsTopologicalSortAlgorithm
    {        
        public static List<OfferedCourseRow> DfsTopologicalSort(List<OfferedCourseRow> inputs)
        {
            List<OfferedCourseRow> topologicalSortedOutputList = new List<OfferedCourseRow>();

            List<DfsGraphVertex> graphVertices = new List<DfsGraphVertex>();

            for (int i = 0; i < inputs.Count; i++)
            {
                var current = inputs[i];
                DfsGraphVertex graphVertex = new DfsGraphVertex();
                graphVertex.Vertex = current;
                graphVertex.Parent = null;
                graphVertex.Color = DfsColor.WHITE;
                graphVertex.Adj = new List<DfsGraphVertex>();

                graphVertices.Add(graphVertex);
            }

            foreach (var v in graphVertices)
            {
                foreach (var r in v.Vertex.OfferedCourse.Course.RequisiteCourses)
                {
                    foreach (var u in graphVertices)
                    {
                        if (v == u) continue;
                        if (u.Vertex.OfferedCourse.Course == r)
                        {
                            v.Adj.Add(u);
                        }
                    }
                }
                foreach (var p in v.Vertex.OfferedCourse.Course.PrerequisiteCourses)
                {
                    foreach (var u in graphVertices)
                    {
                        if (v == u) continue;
                        if (u.Vertex.OfferedCourse.Course == p)
                        {
                            v.Adj.Add(u);
                        }
                    }
                }
            }

            int time = 0;

            foreach (var u in graphVertices)
            {
                if (u.Color == DfsColor.WHITE)
                {
                    DfsVisit(topologicalSortedOutputList, u, ref time);
                }
            }

            return topologicalSortedOutputList;
        }

        private static void DfsVisit(List<OfferedCourseRow> topologicalSortedOutputList, DfsGraphVertex u, ref int time)
        {
            time = time + 1;

            u.StartTime = time;

            u.Color = DfsColor.GRAY;

            foreach (var v in u.Adj)
            {
                if (v.Color == DfsColor.WHITE)
                {
                    v.Parent = u;
                    DfsVisit(topologicalSortedOutputList, v, ref time);
                }
            }

            u.Color = DfsColor.BLACK;
            topologicalSortedOutputList.Add(u.Vertex);

            time = time + 1;

            u.FinishTime = time;

        }

    }

    public class DfsGraphVertex
    {
        public DfsGraphVertex Parent { get; set; }
        public int StartTime { get; set; }
        public int FinishTime { get; set; }
        public DfsColor Color { get; set; }
        public OfferedCourseRow Vertex { get; set; }
        public List<DfsGraphVertex> Adj { get; set; }
    }

    public enum DfsColor
    {
        WHITE,
        GRAY,
        BLACK,
    }
}

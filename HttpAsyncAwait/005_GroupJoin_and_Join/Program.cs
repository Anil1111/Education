using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_GroupJoin_and_Join
{
    class Program
    {
        private static void WriteSequence<TItem>(string prefix, IEnumerable<TItem> sequence,
            bool writeLine = true)
        {
            Console.Write(prefix);
            int index = 0;

            foreach (TItem item in sequence)
            {
                if (index++ >= 1)
                    Console.Write(", ");
                Console.Write(item);
            }

            if (writeLine)
                Console.WriteLine();
        }

        private static void WriteSequence<TKey, TItem>(string prefix,
            IEnumerable<IGrouping<TKey, TItem>> sequence)
        {
            Console.Write(prefix);

            int index = 0;

            foreach (IGrouping<TKey, TItem> grouping in sequence)
            {
                if (index++ >= 1)
                    Console.Write(", ");
                WriteSequence($"[Key={grouping.Key}, Items=", grouping, false);
                Console.Write("]");
            }
            Console.WriteLine();
        }
        //Суть ясна, но детально 
        static void Main(string[] args)
        {
            //Both the GroupJoin and Join methods are unusually complex. Here, we will provide a brief description of each. 
            //In both cases, we will use the following data:

            var courses = new[]
            {
                new { Id = 1, Name = "Geometry" },
                new { Id = 2, Name = "Physics" },
                new { Id = 3, Name = "Parapsychology" },
            };

            var faculty = new[]
            {
                new { CourseId = 1, Name = "Pythagoras" },
                new { CourseId = 1, Name = "Euclid" },
                new { CourseId = 2, Name = "Albert Einstein" },
                new { CourseId = 2, Name = "Isaac Newton"}
            };

            //GroupJoin
            //The GroupJoin method is a bit complex to describe.
            //It joins all of the items in one sequence with matching items from a second sequence.
            //It also groups those matching items. 
            //For those familiar with SQL, it is similar to (but frustratingly different from) a LEFT OUTER JOIN. 
            //The simplest overload accepts the following parameters:
            //  The sequence to join.
            //  A method to get the join key from items in the original sequence.
            //  A method to get the join key from items in the sequence to join.
            //  A method to join an item from the original sequence with a matching item in the sequence to join(or null when no match exists).
            //                  
            var courseFaculty = courses.GroupJoin(//аргумент1
                faculty, //аргумент2
                course => course.Id, //A method to get the join key from items in the original sequence. Т.Е соединяем по  course => course.Id и  teacher => teacher.CourseId
                teacher => teacher.CourseId,//A method to get the join key from items in the sequence to join.
                (course, teachers) => new { Course = course.Name, Teachers = teachers }); //A method to join an item from the original sequence with a matching item in the sequence to join(or null when no match exists).

            Console.Write("GroupBy: ");
            int index = 0;
            foreach (var courseTeachers in courseFaculty)
            {
                if (index++ >= 1)
                    Console.Write(", ");
                WriteSequence($"[Course={courseTeachers.Course}, Teachers=", courseTeachers.Teachers, false);
                Console.Write("]");
            }
            Console.WriteLine();

            //[Course = Geometry, Teachers ={ CourseId = 1, Name = Pythagoras }, { CourseId = 1, Name = Euclid }], 
            //[Course=Physics, Teachers={ CourseId = 2, Name = Albert Einstein }, { CourseId = 2, Name = Isaac Newton }], 
            //[Course=Parapsychology, Teachers=]

            //Because the results of a GroupJoin are a bit unwieldly, one common technique of dealing 
            //with this issue is to “flatten” the results to make them more closely resemble a LEFT OUTER JOIN.

            var flattened = courseFaculty.SelectMany(
                courseTeachers => courseTeachers.Teachers.DefaultIfEmpty(),
                (courseTeachers, teacher) => new { courseTeachers.Course, Teacher = teacher?.Name });
            WriteSequence("GroupBy/SelectMany: ", flattened);

            //{ Course = Geometry, Teacher = Pythagoras },
            //{ Course = Geometry, Teacher = Euclid },
            //{ Course = Physics, Teacher = Albert Einstein },
            //{ Course = Physics, Teacher  Isaac Newton },
            //{ Course = Parapsychology, Teacher =  }


            //Join
            //The Join method joins matching items from two different sequences.
            //For those familiar with SQL, it is nearly identical to LEFT INNER JOIN. The simplest overload accepts the following parameters:

            // The sequence to join.
            //A method to get the join key from items in the original sequence.
            //A method to get the join key from items in the sequence to join.
            //A method to join an item from the original sequence with a matching item in the sequence to join.

            var courseTeacher = courses.Join(
                faculty,
                course => course.Id, //A method to get the join key from items in the original sequence.
                teacher => teacher.CourseId, //A method to get the join key from items in the sequence to join.
                (course, teacher) => new { Course = course.Name, Teacher = teacher.Name }); //A method to join an item from the original sequence with a matching item in the sequence to join.

            WriteSequence("Join: ", courseTeacher);
            //{ Course = Geometry, Teacher = Pythagoras },
            //{ Course = Geometry, Teacher = Euclid },
            //{ Course = Physics, Teacher = Albert Einstein },
            //{ Course = Physics, Teacher = Isaac Newton }
        }
    }
}

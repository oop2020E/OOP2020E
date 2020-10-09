using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCode
{
    class Example
    {
        void foo()
        {
            var str = @" < a class=""nav-item nav-link"" href=""https://www.moodle.aau.dk"" >Home</a>
</li><li class=""nav-item"">
    <a class=""nav-item nav-link"" href=""https://www.moodle.aau.dk/course"" >Courses</a>
</li><li class=""nav-item"">
    <a class=""nav-item nav-link"" href=""https://www.moodle.aau.dk/login/?username=%20"" >Guest</a>
</li><li class=""nav-item"">
    <a class=""nav-item nav-link"" href=""https://www.moodle.aau.dk/course/search.php"" >Search</a>
</li><li class=""dropdown nav-item"">";
            var values = str.Split(new[] { '<', '>' });
            var result = new List<string>();
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(values[i]);
                }
            }
            var strresult = string.Join("", result);

            var linqstr = string.Join("",
                str
                .Split(new[] { '<', '>' })
                .Where((v, i) => i % 2 == 1));
            Console.WriteLine(strresult);
            Console.WriteLine(linqstr);
        }
    }
}
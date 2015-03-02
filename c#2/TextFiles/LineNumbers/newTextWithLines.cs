1  using System;
2  using System.Collections.Generic;
3  using System.Linq;
4  using System.Text;
5  using System.Threading.Tasks;
6  using System.IO;
7  
8  namespace LineNumbers
9  {
10      class LineNumbers
11      {
12          static void Main()
13          {
14              string fileName = @"..\..\LineNumbers.cs";
15              StringBuilder newText = new StringBuilder();
16              string newFileName = @"..\..\newTextWithLines.cs";
17              WriteFile(ReadFile(fileName, newText), newFileName);
18  
19  
20          }
21          public static string ReadFile(string fileName,StringBuilder newText)
22          {
23              StreamReader streamReader1 = new StreamReader(fileName);
24              using (streamReader1)
25              {
26                  string fileLine = "start value";
27                  int counter=1;
28                  while (fileLine!=null)
29                  {
30                      fileLine = streamReader1.ReadLine();
31                      newText.Append(counter+"  " + fileLine+"\n");
32                      counter++;
33                  }
34                 
35                  return newText.ToString();
36              }
37          }
38  
39          public static void WriteFile(string contents, string nameOfNewFile)
40          {
41              StreamWriter streamWriter = new StreamWriter(nameOfNewFile);
42              using (streamWriter)
43              {
44                  streamWriter.WriteLine(contents);
45  
46              }
47  
48          }
49  
50      }
51  }
52  
53  










#region CpBook_2, Problem: 3.1
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filename = "my_file.txt";

        // Open the file for writing
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Write content to the file
            writer.Write("This is a file created by my program! ");
            writer.Write("I am so happy.");
        }

        Console.WriteLine("File has been written successfully.");
    }
}

#endregion

#region CpBook_2, Problem: 3.2
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filename = "my_file.txt";

//        // Open the file for writing
//        using (StreamWriter writer = new StreamWriter(filename))
//        {
//            // Write content to the file
//            writer.Write("This is a file created by my program! ");
//            writer.Write("I am so happy.\n");
//        }

//        Console.WriteLine("File has been written successfully.");

//        // Attempt to write again after the file is closed (this will be caught by an error)
//        try
//        {
//            using (StreamWriter writer = new StreamWriter(filename, true))
//            {
//                // Write the second line to the file (this will append since 'true' is passed)
//                writer.WriteLine("Second line.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.3
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filename = "files\\my_file.txt";

//        // Open the file for writing (this will overwrite any existing content)
//        using (StreamWriter writer = new StreamWriter(filename))
//        {
//            writer.Write("This is a file created by my program! ");
//            writer.Write("I am so happy.\n");
//        }

//        Console.WriteLine("File has been written successfully.");

//        // Reopen the file in append mode and add more content
//        using (StreamWriter writer = new StreamWriter(filename, true))
//        {
//            writer.WriteLine("Second line.");
//        }

//        Console.WriteLine("Second line has been appended to the file.");
//    }
//}

#endregion

#region CpBook_2, Problem: 3.4
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string inputFile = "files\\in.txt";
//        string outputFile = "files\\out.txt";

//        // Read numbers from input file
//        try
//        {
//            string[] lines = File.ReadAllLines(inputFile);
//            int num1 = int.Parse(lines[0]);
//            int num2 = int.Parse(lines[1]);

//            // Calculate sum
//            int sum = num1 + num2;

//            // Print the result to the console
//            Console.WriteLine($"{num1} {num2} {sum}");

//            // Write the sum to the output file
//            File.WriteAllText(outputFile, sum.ToString());
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.5
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string inputFile = "files\\in.txt";
//        string outputFile = "files\\out.txt";

//        // Read the line from the input file
//        try
//        {
//            string line = File.ReadAllText(inputFile);
//            string[] numbers = line.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

//            // Parse the numbers
//            int num1 = int.Parse(numbers[0]);
//            int num2 = int.Parse(numbers[1]);

//            // Calculate sum
//            int sum = num1 + num2;

//            // Print the result to the console
//            Console.WriteLine($"{num1} {num2} {sum}");

//            // Write the sum to the output file
//            File.WriteAllText(outputFile, sum.ToString());
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.6
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string inputFile = "files\\github.png";
//        string outputFile = "files\\github - Copy.png";

//        try
//        {
//            // Read all bytes from the input file
//            byte[] fileBytes = File.ReadAllBytes(inputFile);

//            // Write the bytes to the output file
//            File.WriteAllBytes(outputFile, fileBytes);

//            Console.WriteLine("File copied successfully.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.7
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string inputFile = "files\\in3_7.txt";

//        try
//        {
//            // Open the file for reading
//            using (FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
//            {
//                // Create a StreamReader to read the file
//                using (StreamReader reader = new StreamReader(fs))
//                {
//                    // Read and print the first character
//                    int ch = reader.Read();
//                    if (ch != -1)
//                        Console.WriteLine((char)ch);

//                    // Read and print the second character
//                    ch = reader.Read();
//                    if (ch != -1)
//                        Console.WriteLine((char)ch);

//                    // Move the file pointer back to the beginning using Seek
//                    fs.Seek(0, SeekOrigin.Begin);

//                    // Read and print the first character again
//                    ch = reader.Read();
//                    if (ch != -1)
//                        Console.WriteLine((char)ch);
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.8
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "files\\github.png";

//        try
//        {
//            // Check if the file exists
//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("File not found.");
//                return;
//            }

//            // Open the file and determine its size
//            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            {
//                long fileSize = fs.Length; // Get file size in bytes
//                Console.WriteLine($"File Size: {fileSize} bytes");
//                Console.WriteLine($"File Size (KiloByte): {fileSize / 1024} KB");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: 3.9
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filename = "files\\image1.png";

//        try
//        {
//            // Attempt to delete the file
//            if (File.Exists(filename))
//            {
//                File.Delete(filename);
//                Console.WriteLine($"{filename} removed successfully");
//            }
//            else
//            {
//                Console.WriteLine($"File '{filename}' does not exist.");
//            }

//            // Attempt to delete the file again
//            if (File.Exists(filename))
//            {
//                File.Delete(filename);
//                Console.WriteLine($"{filename} removed successfully");
//            }
//            else
//            {
//                Console.WriteLine($"File '{filename}' does not exist.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"File Remove Failed: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: Modified 3.7
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "files\\in3_7.txt";

//        try
//        {
//            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            {
//                // Read and print the first character
//                int ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);

//                // Read and print the second character
//                ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);

//                // Move the pointer to the start of the file (SEEK_SET equivalent)
//                fs.Seek(0, SeekOrigin.Begin);
//                ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);

//                // Move the pointer to the current position (SEEK_CUR equivalent)
//                fs.Seek(0, SeekOrigin.Current);
//                ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: Page 52
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string mathFile = "files\\math.txt";
//        string banglaFile = "files\\bangla.txt";
//        string englishFile = "files\\english.txt";
//        string averageFile = "files\\average.txt";

//        try
//        {
//            // Open files for reading and writing
//            using (StreamReader mathReader = new StreamReader(mathFile))
//            using (StreamReader banglaReader = new StreamReader(banglaFile))
//            using (StreamReader englishReader = new StreamReader(englishFile))
//            using (StreamWriter averageWriter = new StreamWriter(averageFile, append: true))
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    // Read math marks
//                    string mathLine = mathReader.ReadLine();
//                    string[] mathData = mathLine.Split(' ');
//                    int roll = int.Parse(mathData[0]);
//                    int mathMark = int.Parse(mathData[1]);

//                    // Read Bangla marks
//                    string banglaLine = banglaReader.ReadLine();
//                    string[] banglaData = banglaLine.Split(' ');
//                    int banglaMark = int.Parse(banglaData[1]);

//                    // Read English marks
//                    string englishLine = englishReader.ReadLine();
//                    string[] englishData = englishLine.Split(' ');
//                    int englishMark = int.Parse(englishData[1]);

//                    // Calculate the average
//                    float averageMark = (mathMark + banglaMark + englishMark) / 3.0f;

//                    // Write to the average file
//                    averageWriter.WriteLine($"{roll} {averageMark:F2}");
//                }
//            }

//            Console.WriteLine("Average marks calculated and written successfully.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion

#region CpBook_2, Problem: Page 60
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string filePath = "files\\in3_7.txt";

//        try
//        {
//            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            {
//                // Read and print the first character
//                int ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);

//                // Read and print the second character
//                ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);

//                // Skip the next 3 characters (SEEK_CUR equivalent)
//                fs.Seek(3, SeekOrigin.Current);

//                // Read and print the character after skipping
//                ch = fs.ReadByte();
//                if (ch != -1)
//                    Console.WriteLine((char)ch);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion
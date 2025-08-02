namespace pages_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("output"))
                Directory.Delete("output");

            Directory.CreateDirectory("output");
            File.WriteAllText("output/index.html",
@"<html>
<body>

<h1>My First Heading</h1>
<p>My first paragraph.</p>

</body>
</html>");
        }
    }
}

using System.Reflection;
using System.Linq;

class student
{
    public string name;
    public int weight;

    public student(string modelName, int modelWeight)
    {
        name = modelName;
        weight = modelWeight;

    }
    static void main(string[]  args)
    {
        student student1 = new student("haroon", 82 );
        student student2 = new student("ta",65);
        student student3 = new student("ley",90);
        student student4 = new student("kang",82);
        student student5 = new student("pee",62);
        int[] weightist = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int max = weightist.Max();
        int min = weightist.Min();
        Console.WriteLine('ค่าเฉลี่ยทั้งหมด' + (student1.weight+ student2.weight+ student3.weight+ student4.weight+ student5.weight) / 5);
        Console.WriteLine("น้ำหนักมากที่สุด" + max);
        Console.WriteLine("น้ำหนักน้อยสุด" + min);
        Console.WriteLine("วงศธร ทองอินทร์ 6534501017");
    }
}
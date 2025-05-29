//reverse a string
string original = args.FirstOrDefault() ?? "Hello, World!";
string reversed = new string(original.Reverse().ToArray());

Console.WriteLine("Reversed string: " + reversed);
Console.WriteLine("Original string: " + original);

if (original.ToLower() == reversed.ToLower())
{
    Console.WriteLine($"{original} is a palindrome.");
}
else
{
    Console.WriteLine($"{original} is not a palindrome.");
}
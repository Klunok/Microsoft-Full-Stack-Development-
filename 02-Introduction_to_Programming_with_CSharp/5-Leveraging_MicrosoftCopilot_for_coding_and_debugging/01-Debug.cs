// Insert this else-if branch inside the main loop alongside add/remove/list/exit

else if (action == "search")

{

    // Check if there are any books at all

    if (string.IsNullOrEmpty(book1) &&

        string.IsNullOrEmpty(book2) &&

        string.IsNullOrEmpty(book3) &&

        string.IsNullOrEmpty(book4) &&

        string.IsNullOrEmpty(book5))

    {

        Console.WriteLine("No books in the library to search.");

        continue;

    }


    Console.Write("Enter search term (title or part of title): ");

    string query = (Console.ReadLine() ?? "").Trim();

    if (string.IsNullOrEmpty(query))

    {

        Console.WriteLine("No search term entered. Cancelled search.");

        continue;

    }


    // Case-insensitive substring search

    string q = query.ToLower();

    bool foundAny = false;

    if (!string.IsNullOrEmpty(book1) && book1.ToLower().Contains(q))

    {

        Console.WriteLine($"Found in slot 1: {book1}");

        foundAny = true;

    }

    if (!string.IsNullOrEmpty(book2) && book2.ToLower().Contains(q))

    {

        Console.WriteLine($"Found in slot 2: {book2}");

        foundAny = true;

    }

    if (!string.IsNullOrEmpty(book3) && book3.ToLower().Contains(q))

    {

        Console.WriteLine($"Found in slot 3: {book3}");

        foundAny = true;

    }

    if (!string.IsNullOrEmpty(book4) && book4.ToLower().Contains(q))

    {

        Console.WriteLine($"Found in slot 4: {book4}");

        foundAny = true;

    }

    if (!string.IsNullOrEmpty(book5) && book5.ToLower().Contains(q))

    {

        Console.WriteLine($"Found in slot 5: {book5}");

        foundAny = true;

    }


    if (!foundAny) Console.WriteLine($"No books matched \"{query}\".");

}
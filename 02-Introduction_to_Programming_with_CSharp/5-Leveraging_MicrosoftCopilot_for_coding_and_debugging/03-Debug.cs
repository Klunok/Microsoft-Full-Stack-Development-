// Inside the "borrow" branch after matching the title

if (!string.IsNullOrEmpty(book1) && book1.Equals(titleToBorrow, StringComparison.OrdinalIgnoreCase))

{

    if (!borrowed1) { borrowed1 = true; borrowedCount++; borrowed = true; }

    else Console.WriteLine($"\"{book1}\" is already borrowed.");

}

else if (!string.IsNullOrEmpty(book2) && book2.Equals(titleToBorrow, StringComparison.OrdinalIgnoreCase))

{

    if (!borrowed2) { borrowed2 = true; borrowedCount++; borrowed = true; }

    else Console.WriteLine($"\"{book2}\" is already borrowed.");

}

// Repeat same pattern for book3, book4, book5

// Inside the "return" branch after matching the title

if (!string.IsNullOrEmpty(book1) && book1.Equals(titleToReturn, StringComparison.OrdinalIgnoreCase) && borrowed1)

{

    borrowed1 = false;

    borrowedCount--;

    returned = true;

}

else if (!string.IsNullOrEmpty(book2) && book2.Equals(titleToReturn, StringComparison.OrdinalIgnoreCase) && borrowed2)

{

    borrowed2 = false;

    borrowedCount--;

    returned = true;

}

// Repeat same pattern for book3, book4, book5

// Inside the "list" branch

if (!string.IsNullOrEmpty(book1)) Console.WriteLine($"1. {book1}" + (borrowed1 ? " (Borrowed)" : ""));

if (!string.IsNullOrEmpty(book2)) Console.WriteLine($"2. {book2}" + (borrowed2 ? " (Borrowed)" : ""));

// Repeat for book3, book4, book5
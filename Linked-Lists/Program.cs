


class WebPageNode
{
    public string Url;
    public string Title;
    public WebPageNode Next;
    public WebPageNode Previous;

    public WebPageNode(string url, string title)
    {
        Url = url;
        Title = title;
        Next = null;
        Previous = null;
    }
}

// History class using a doubly linked list
class WebPageHistory
{
    private WebPageNode head;
    private WebPageNode current;

    public WebPageHistory()
    {
        head = null;
        current = null;
    }

    // Method to visit a webpage and add it to history
    public void VisitWebPage(string url, string title)
    {
        WebPageNode newPage = new WebPageNode(url, title);

        if (head == null)
        {
            head = newPage;
            current = head;
        }
        else
        {
            current.Next = newPage;
            newPage.Previous = current;
            current = newPage;
        }
    }

    // Method to navigate back to the previous webpage
    public void Back()
    {
        if (current != null && current.Previous != null)
        {
            current = current.Previous;
        }
        else
        {
            Console.WriteLine("Cannot go back. End of history.");
        }
    }

    // Method to navigate forward to the next webpage
    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
        else
        {
            Console.WriteLine("Cannot go forward. End of history.");
        }
    }

    // Method to display all webpages in the history
    public void DisplayHistory()
    {
        if (head == null)
        {
            Console.WriteLine("History is empty.");
            return;
        }

        Console.WriteLine("Webpage History:");

        WebPageNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", URL: " + temp.Url);
            temp = temp.Next;
        }
    }
}

// Main program to demonstrate webpage history management
class Program
{
    static void Main(string[] args)
    {
        WebPageHistory history = new WebPageHistory();

        // Visit some webpages
        history.VisitWebPage("https://www.google.com", "Google");
        history.VisitWebPage("https://www.wikipedia.org", "Wikipedia");
        history.VisitWebPage("https://www.github.com", "GitHub");

        // Display initial history
        history.DisplayHistory();

        // Perform back navigation
        history.Back();
        Console.WriteLine("\nAfter going back:");
        history.DisplayHistory();

        // Perform forward navigation
        history.Forward();
        Console.WriteLine("\nAfter going forward:");
        history.DisplayHistory();
    }
}



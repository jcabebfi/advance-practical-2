public delegate void ProgressUpdate(int progressPercentage);

public class Downloader
{
    private int _progress;
    public event ProgressUpdate ProgressChanged;

    public int Progress
    {
        get { return _progress; }
        set
        {
            if (_progress != value)
            {
                _progress = value;
                OnProgressChanged(_progress);
            }
        }
    }

    protected virtual void OnProgressChanged(int progress)
    {
        ProgressChanged?.Invoke(progress);
    }

    public static void Main()
    {
        Downloader downloader = new Downloader();
        downloader.ProgressChanged += (progressPercentage) =>
        {
            Console.WriteLine($"Download Progress: {progressPercentage}%");
        };

        // Simulate download progress
        for (int i = 0; i <= 100; i += 10)
        {
            downloader.Progress = i;
            Thread.Sleep(500); // Simulate time delay between progress updates
        }
    }
}


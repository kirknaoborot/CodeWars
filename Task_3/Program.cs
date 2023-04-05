var result = GetReadableTime(60);

Console.WriteLine(result);
static string GetReadableTime(int inputSeconds)
{
    var time = TimeSpan.FromSeconds(inputSeconds);

    var hours = time.TotalHours < 10 ? $"0{Convert.ToInt32(Math.Floor(time.TotalHours))}" : Convert.ToInt32(Math.Floor(time.TotalHours)).ToString();

    var minutes = time.Minutes < 10 ? $"0{time.Minutes}" : time.Minutes.ToString();

    var seconds = time.Seconds < 10 ? $"0{time.Seconds}" : time.Seconds.ToString();

    return $"{hours}:{minutes}:{seconds}";
}
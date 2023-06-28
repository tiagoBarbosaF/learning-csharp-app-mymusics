namespace MyMusics.Models.Bands;

internal class Appraisal
{
    public int Rate { get; }

    public Appraisal(int rate)
    {
        Rate = rate < 0 ? 0 : rate > 10 ? 10 : rate;
    }

    public static Appraisal Parse(string text)
    {
        var rate = int.Parse(text);

        return new Appraisal(rate);
    }
}
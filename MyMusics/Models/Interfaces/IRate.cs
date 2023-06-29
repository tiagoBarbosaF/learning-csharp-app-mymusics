using MyMusics.Models.Bands;

namespace MyMusics.Models.Interfaces;

internal interface IRate
{
    void AddRate(Appraisal rate);
    double Average { get; }
}
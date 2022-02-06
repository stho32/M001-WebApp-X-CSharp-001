namespace genny.Interfaces.Entities;

public interface IDatabaseColumn
{
    string Name { get; }
    string DataType { get; }
    int MaxLength { get; }
    /// <summary>
    /// Total number of digits
    /// </summary>
    int Precision { get; }
    /// <summary>
    /// Number of decimals, position "where the comma is in a number of the length precision"
    /// </summary>
    int Scale { get; }
    bool IsPrimaryKey { get; }
}
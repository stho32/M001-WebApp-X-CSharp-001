namespace genny.Interfaces.Entities;

public interface IDatabaseObject
{
    string Schema { get; }
    string Name { get; }
    
    IDatabaseColumn[] Columns { get; }
}
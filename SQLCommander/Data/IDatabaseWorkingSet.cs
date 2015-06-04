namespace SQLCommander.Data
{
    interface IDatabaseWorkingSet
    {
        System.Collections.Generic.List<Table> Tables { get; }
        System.Collections.Generic.List<User> Users { get; }
    }
}

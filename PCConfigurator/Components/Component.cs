namespace PCConfigurator.Components
{
    /// <summary>
    /// Компонент ПК
    /// </summary>
    public class Component
    {
        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; }

        public Component(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

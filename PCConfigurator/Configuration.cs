using System.Collections.Generic;
using PCConfigurator.Components;

namespace PCConfigurator
{
    /// <summary>
    /// Конфигурация ПК
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Мониторы
        /// </summary>
        public IReadOnlyCollection<Component> Monitors { get; }

        /// <summary>
        /// Видеокарта
        /// </summary>
        public Component GraphicsCard { get; }
    }
}

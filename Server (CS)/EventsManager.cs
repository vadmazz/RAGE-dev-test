using System;

namespace Server__CS_
{
    /// <summary>
    /// Абстрактный класс работы с событиями
    /// </summary>
    internal static class EventsManager
    {
        /// <summary>
        /// Подписаться на событие
        /// </summary>
        public static void Subscribe(string eventName, Action callback)
        {
            // логика только предполагается, её тут быть не должно
        }

        /// <summary>
        /// Вызвать клиентское событие
        /// </summary>
        /// <param name="eventName">Название события</param>
        /// <param name="data">Передаваемые параметры</param>
        public static void RaiseEvent(string eventName, params object[] data)
        {
            // логика только предполагается, её тут быть не должно
        }

        /// <summary>
        /// Вызвать клиентское событие
        /// </summary>
        /// <param name="eventName">Название события</param>
        /// <param name="obj">Сериализованный объект</param>
        /// <typeparam name="T">Тип сериализуемого объекта</typeparam>
        public static void RaiseEvent<T>(string eventName, T obj)
        {
            // логика только предполагается, её тут быть не должно
        }
    }
}
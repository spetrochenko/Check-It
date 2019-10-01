using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CheckIt.Core.Utils.ObservableCollectionExtension
{
    /// <inheritdoc />
    /// <summary>
    /// Extension class for observable collection which provide functions to add sequence in collection and remove sequence from collection without notify when each element will be add or remove.
    /// </summary>
    /// <typeparam name="T">Entity which used in collection.</typeparam>
    public sealed class ExtendedObservableCollection<T> : ObservableCollection<T>
    {
        private bool suspressNotifications;

        /// <summary>
        /// Provide adding sequence to current collection without notify.
        /// </summary>
        /// <param name="sequence">Sequence need to be add.</param>
        public void AddRange(IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            suspressNotifications = true;

            foreach (var item in sequence)
            {
                Add(item);
            }

            suspressNotifications = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
        }

        /// <summary>
        ///  Provide removing sequence to current collection without notify.
        /// </summary>
        /// <param name="sequence">Sequence need to be remove.</param>
        public void RemoveRange(IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            suspressNotifications = true;

            foreach (var item in sequence)
            {
                Remove(item);
            }

            suspressNotifications = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (!suspressNotifications)
            {
                base.OnCollectionChanged(e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CheckIt.Core.Utils.ObservableCollectionExtension
{
    public sealed class ExtendedObservableCollection<T> : ObservableCollection<T>
    {
        private bool suspressNotifications;

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

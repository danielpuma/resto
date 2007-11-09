using System;
using System.Collections.Generic;
using FSO_NHDATA;


namespace FSO_NH.Data
{
    /////// <summary>
    /////// Indicates the direction for sorting
    /////// </summary>
    ////public enum SortDirection
    ////{
    ////    /// <summary>
    ////    /// Bottom to top, or oldest to youngest
    ////    /// </summary>
    ////    Ascending,

    ////    /// <summary>
    ////    /// Top to bottom, or youngest to oldest
    ////    /// </summary>
    ////    Descending
    ////}

    /// <summary>
    /// A simple field by which to sort by
    /// </summary>
    public class SortableProperty
    {
        private string _propertyName;
        private SortDirection _direction;

        /// <summary>
        /// Constructor
        /// </summary>
        public SortableProperty()
        {
            this.PropertyName = string.Empty;
            this.Direction = SortDirection.Ascending;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SortableProperty(string propertyName)
            : this()
        {
            this.PropertyName = propertyName;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SortableProperty(string propertyName, SortDirection direction)
        {
            this.PropertyName = propertyName;
            this.Direction = direction;
        }

        /// <summary>
        /// The name of the property to sort
        /// </summary>
        public string PropertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; }
        }

        /// <summary>
        /// The direction in which to sort
        /// </summary>
        public SortDirection Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
    }

    /// <summary>
    /// A generic comparer that can sort by multiple properties on items in a list
    /// </summary>
    public class MultiPropertyComparer<T> : IComparer<T>
    {
        private List<SortableProperty> _sortableProperties;

        /// <summary>
        /// Constructor
        /// </summary>
        public MultiPropertyComparer()
        {
            this.SortableProperties = new List<SortableProperty>();
        }

        /// <summary>
        /// The properties to compare and their directions by which to sort
        /// </summary>
        public List<SortableProperty> SortableProperties
        {
            get { return _sortableProperties; }
            set { _sortableProperties = value; }
        }

        /// <summary>
        /// Compares two objects
        /// </summary>
        public int Compare(T x, T y)
        {
            if (SortableProperties.Count == 0)
            {
                return 0;
            }
            return RecursiveCompare(0, x, y);
        }

        /// <summary>
        /// Recursively compares
        /// </summary>
        public int RecursiveCompare(int step, T x, T y)
        {
            int result = 0;
            if (step < SortableProperties.Count)
            {
                // Get the values of each fields property
                object valueOfX = x.GetType().GetProperty(SortableProperties[step].PropertyName).GetValue(x, null);
                object valueOfY = y.GetType().GetProperty(SortableProperties[step].PropertyName).GetValue(y, null);

                if (SortableProperties[step].Direction == SortDirection.Ascending)
                {
                    result = ((IComparable) valueOfX).CompareTo((IComparable) valueOfY);
                }
                else
                {
                    result = ((IComparable) valueOfY).CompareTo((IComparable) valueOfX);
                }

                if (result == 0)
                {
                    // The comparrison revealed the two fields were the same, so try the next one
                    result = RecursiveCompare(step + 1, x, y);
                }
            }
            return result;
        }
    }
}
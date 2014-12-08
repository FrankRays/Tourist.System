using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tourist.Data.Classes
{
	public class DependableCollection<T> : ICollection<T>
	{
		public DependableCollection( IList aList )
		{
			Dependable = aList;
		}

		public IList Dependable { get; private set; }

		public void Add( T item )
		{
			Dependable.Add( item );
		}

		public void Clear( )
		{
			throw new NotSupportedException( );
		}

		public bool Contains( T item )
		{
			return Dependable.Contains( item );
		}

		public void CopyTo( T[ ] array, int arrayIndex )
		{
			Dependable.CopyTo( array, arrayIndex );
		}

		public int Count
		{
			get { return Dependable.OfType<T>( ).Count( ); }
		}

		public bool IsReadOnly
		{
			get { return Dependable.IsReadOnly; }
		}

		public bool Remove( T item )
		{
			if ( !Dependable.Contains( item ) ) return false;
			Dependable.Remove( item );
			return true;
		}

		public IEnumerator<T> GetEnumerator( )
		{
			return Dependable.OfType<T>( ).GetEnumerator( );
		}

		IEnumerator IEnumerable.GetEnumerator( )
		{
			return Dependable.OfType<T>( ).GetEnumerator( );
		}
	}
}
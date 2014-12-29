using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Tourist.Data.Classes
{
	public class ObservableList<T> : ObservableCollection<T> where T : INotifyPropertyChanged
	{
		public ObservableList( )
		{
			CollectionChanged += ObservableList_CollectionChanged;
		}

		public void ObservableList_CollectionChanged( object sender, NotifyCollectionChangedEventArgs e )
		{
			if ( e.NewItems != null )
			{
				foreach ( var item in e.NewItems )
				{
					( (INotifyPropertyChanged) item ).PropertyChanged += Item_PropertyChanged;
				}
			}
			if ( e.OldItems != null )
			{
				foreach ( var item in e.OldItems )
				{
					( (INotifyPropertyChanged) item ).PropertyChanged -= Item_PropertyChanged;
				}
			}
		}

		public void Item_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			var a = new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Reset );
			OnCollectionChanged( a );
		}
	}
}
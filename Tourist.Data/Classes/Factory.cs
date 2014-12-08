namespace Tourist.Data.Classes
{
	/*
	public class Factory : IFactory
	{
		
		 public Type[] GetTypes()
		 {
			 return new[] {
				 typeof (Order), typeof (OrderItem), typeof(Client), typeof(Product), typeof(ProductCategory)
			 };
		 }

		 public IOrder CreateOrder()
		 {
			 return new Order();
		 }

		 public IOrderItem CreateOrderItem()
		 {
			 return new OrderItem();
		 }

		 public IClient CreateClient()
		 {
			 return new Client();
		 }

		 public IProduct CreateProduct()
		 {
			 return new Product();
		 }

		 public IProductCategory CreateProductCategory()
		 {
			 return new ProductCategory();
		 }

		 public object CreateObject( string aType )
		 {
			 switch ( aType )
			 {
			 case "Order":
				 return CreateOrder();
			 case "Client":
				 return CreateClient();
			 case "OrderItem":
				 return CreateOrderItem();
			 case "Product":
				 return CreateProduct();
			 case "ProductCategory":
				 return CreateProductCategory();
			 default:
				 return null;
			 }
		 }

		 /// <summary>
		 /// Create an object based on a given interface type  
		 /// </summary>
		 /// <remarks>This method assumes that interface type name starts with a 'I'</remarks>
		 /// <typeparam name="T">the interface type</typeparam>
		 /// <returns>An object that implements the given interface type</returns>
		 public T CreateObject<T>()
		 {
			 return Cast<T>( CreateObject( typeof (T).Name.Substring( 1 ) ) );
		 }

		 public static T Cast<T>( object o )
		 {
			 return (T) o;
		 }
		
	 }
		
	}
	
	}
	 */
}

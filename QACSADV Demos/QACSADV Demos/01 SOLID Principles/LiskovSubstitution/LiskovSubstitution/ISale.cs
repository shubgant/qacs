namespace LiskovSubstitution {
	public interface ISale {
		void AddSaleToDatabase(string product, decimal totalSales);
	}
}
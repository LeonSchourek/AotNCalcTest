namespace AotNCalcTest
{
	public class ProductpData
	{
		public ProductpData(uint price, float mwst)
		{
			this.Price = price;
			this.Mwst = mwst;
		}

		public uint Price { get; set; }

		public float Mwst { get; set; }

		public uint MwstMoney => (uint)Math.Round(this.Price * this.Mwst);

		public ulong FullPrice => (ulong)Math.Round(this.Price * (this.Mwst + 1));
	};
}
using Terraria.ModLoader;

namespace MagicStorageExtra.Items
{
	public abstract class StorageItem : ModItem
	{
		public sealed override void AddRecipes()
		{
			AddRecipe(this);
			if (MagicStorageExtra.MagicStorage != null)
				AddRecipe(MagicStorageExtra.MagicStorage.GetItem(Name));
		}

		public virtual void AddRecipe(ModItem result)
		{
		}
	}
}

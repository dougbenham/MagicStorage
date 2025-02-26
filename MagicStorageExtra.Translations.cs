﻿using Terraria.Localization;
using Terraria.ModLoader;

namespace MagicStorageExtra
{
	public partial class MagicStorageExtra
	{
		private void AddTranslations()
		{
			ModTranslation text = CreateTranslation("SetTo");
			text.SetDefault("Set to: X={0}, Y={1}");
			text.AddTranslation(GameCulture.Polish, "Ustawione na: X={0}, Y={1}");
			text.AddTranslation(GameCulture.French, "Mis à: X={0}, Y={1}");
			text.AddTranslation(GameCulture.Spanish, "Ajustado a: X={0}, Y={1}");
			text.AddTranslation(GameCulture.Chinese, "已设置为: X={0}, Y={1}");
			AddTranslation(text);

			text = CreateTranslation("SnowBiomeBlock");
			text.SetDefault("Snow Biome Block");
			text.AddTranslation(GameCulture.French, "Bloc de biome de neige");
			text.AddTranslation(GameCulture.Spanish, "Bloque de Biomas de la Nieve");
			text.AddTranslation(GameCulture.Chinese, "雪地环境方块");
			AddTranslation(text);

			text = CreateTranslation("DepositAll");
			text.SetDefault("Transfer All");
			text.AddTranslation(GameCulture.Russian, "Переместить всё");
			text.AddTranslation(GameCulture.French, "Déposer tout");
			text.AddTranslation(GameCulture.Spanish, "Depositar todo");
			text.AddTranslation(GameCulture.Chinese, "全部存入");
			AddTranslation(text);

			text = CreateTranslation("SearchName");
			text.SetDefault("Search Name");
			text.AddTranslation(GameCulture.Russian, "Поиск по имени");
			text.AddTranslation(GameCulture.French, "Recherche par nom");
			text.AddTranslation(GameCulture.Spanish, "búsqueda por nombre");
			text.AddTranslation(GameCulture.Chinese, "搜索名称");
			AddTranslation(text);

			text = CreateTranslation("CraftAmount");
			text.SetDefault("Craft amount");
			AddTranslation(text);

			text = CreateTranslation("SearchMod");
			text.SetDefault("Search Mod");
			text.AddTranslation(GameCulture.Russian, "Поиск по моду");
			text.AddTranslation(GameCulture.French, "Recherche par mod");
			text.AddTranslation(GameCulture.Spanish, "búsqueda por mod");
			text.AddTranslation(GameCulture.Chinese, "搜索模组");
			AddTranslation(text);

			text = CreateTranslation("SortDefault");
			text.SetDefault("Default Sorting");
			text.AddTranslation(GameCulture.Russian, "Стандартная сортировка");
			text.AddTranslation(GameCulture.French, "Tri Standard");
			text.AddTranslation(GameCulture.Spanish, "Clasificación por defecto");
			text.AddTranslation(GameCulture.Chinese, "默认排序");
			AddTranslation(text);

			text = CreateTranslation("SortID");
			text.SetDefault("Sort by ID");
			text.AddTranslation(GameCulture.Russian, "Сортировка по ID");
			text.AddTranslation(GameCulture.French, "Trier par ID");
			text.AddTranslation(GameCulture.Spanish, "Ordenar por ID");
			text.AddTranslation(GameCulture.Chinese, "按ID排序");
			AddTranslation(text);

			text = CreateTranslation("SortName");
			text.SetDefault("Sort by Name");
			text.AddTranslation(GameCulture.Russian, "Сортировка по имени");
			text.AddTranslation(GameCulture.French, "Trier par nom");
			text.AddTranslation(GameCulture.Spanish, "Ordenar por nombre");
			text.AddTranslation(GameCulture.Chinese, "按名称排序");
			AddTranslation(text);

			text = CreateTranslation("SortStack");
			text.SetDefault("Sort by Stacks");
			text.AddTranslation(GameCulture.Russian, "Сортировка по стакам");
			text.AddTranslation(GameCulture.French, "Trier par piles");
			text.AddTranslation(GameCulture.Spanish, "Ordenar por pilas");
			text.AddTranslation(GameCulture.Chinese, "按堆栈排序");
			AddTranslation(text);

			text = CreateTranslation("SortValue");
			text.SetDefault("Sort by Value");
			text.AddTranslation(GameCulture.Russian, "Сортировать по значению");
			text.AddTranslation(GameCulture.French, "Trier par valeur");
			text.AddTranslation(GameCulture.Spanish, "Ordenar por valor");
			text.AddTranslation(GameCulture.Chinese, "按值排序");
			AddTranslation(text);

			text = CreateTranslation("FilterAll");
			text.SetDefault("Filter All");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Всё)");
			text.AddTranslation(GameCulture.French, "Filtrer tout");
			text.AddTranslation(GameCulture.Spanish, "Filtrar todo");
			text.AddTranslation(GameCulture.Chinese, "筛选全部");
			AddTranslation(text);

			text = CreateTranslation("FilterWeapons");
			text.SetDefault("Filter Weapons");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Оружия)");
			text.AddTranslation(GameCulture.French, "Filtrer par armes");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por armas");
			text.AddTranslation(GameCulture.Chinese, "筛选武器");
			AddTranslation(text);

			text = CreateTranslation("FilterTools");
			text.SetDefault("Filter Tools");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Инструменты)");
			text.AddTranslation(GameCulture.French, "Filtrer par outils");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por herramientas");
			text.AddTranslation(GameCulture.Chinese, "筛选工具");
			AddTranslation(text);

			text = CreateTranslation("FilterEquips");
			text.SetDefault("Filter Equipment");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Снаряжения)");
			text.AddTranslation(GameCulture.French, "Filtrer par Équipement");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por equipamiento");
			text.AddTranslation(GameCulture.Chinese, "筛选装备");
			AddTranslation(text);

			text = CreateTranslation("FilterWeaponsMelee");
			text.SetDefault("Filter Melee Weapons");
			AddTranslation(text);

			text = CreateTranslation("FilterWeaponsRanged");
			text.SetDefault("Filter Ranged Weapons");
			AddTranslation(text);

			text = CreateTranslation("FilterWeaponsMagic");
			text.SetDefault("Filter Magic Weapons");
			AddTranslation(text);

			text = CreateTranslation("FilterWeaponsSummon");
			text.SetDefault("Filter Summons");
			AddTranslation(text);

			text = CreateTranslation("FilterWeaponsThrown");
			text.SetDefault("Filter Throwing Weapons");
			AddTranslation(text);

			text = CreateTranslation("FilterAmmo");
			text.SetDefault("Filter Ammo");
			AddTranslation(text);

			text = CreateTranslation("FilterArmor");
			text.SetDefault("Filter Armor");
			AddTranslation(text);

			text = CreateTranslation("FilterVanity");
			text.SetDefault("Filter Vanity Items");
			AddTranslation(text);

			text = CreateTranslation("FilterPotions");
			text.SetDefault("Filter Potions");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Зелья)");
			text.AddTranslation(GameCulture.French, "Filtrer par potions");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por poción");
			text.AddTranslation(GameCulture.Chinese, "筛选药水");
			AddTranslation(text);

			text = CreateTranslation("FilterTiles");
			text.SetDefault("Filter Placeables");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Размещаемое)");
			text.AddTranslation(GameCulture.French, "Filtrer par placeable");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por metido");
			text.AddTranslation(GameCulture.Chinese, "筛选放置物");
			AddTranslation(text);

			text = CreateTranslation("FilterMisc");
			text.SetDefault("Filter Misc");
			text.AddTranslation(GameCulture.Russian, "Фильтр (Разное)");
			text.AddTranslation(GameCulture.French, "Filtrer par miscellanées");
			text.AddTranslation(GameCulture.Spanish, "Filtrar por otros");
			text.AddTranslation(GameCulture.Chinese, "筛选杂项");
			AddTranslation(text);

			text = CreateTranslation("FilterRecent");
			text.SetDefault("Filter New Recently Added Items");
			AddTranslation(text);

			text = CreateTranslation("CraftingStations");
			text.SetDefault("Crafting Stations");
			text.AddTranslation(GameCulture.Russian, "Станции создания");
			text.AddTranslation(GameCulture.French, "Stations d'artisanat");
			text.AddTranslation(GameCulture.Spanish, "Estaciones de elaboración");
			text.AddTranslation(GameCulture.Chinese, "制作站");
			AddTranslation(text);

			text = CreateTranslation("Recipes");
			text.SetDefault("Recipes");
			text.AddTranslation(GameCulture.Russian, "Рецепты");
			text.AddTranslation(GameCulture.French, "Recettes");
			text.AddTranslation(GameCulture.Spanish, "Recetas");
			text.AddTranslation(GameCulture.Chinese, "合成配方");
			AddTranslation(text);

			text = CreateTranslation("SelectedRecipe");
			text.SetDefault("Selected Recipe");
			text.AddTranslation(GameCulture.French, "Recette sélectionnée");
			text.AddTranslation(GameCulture.Spanish, "Receta seleccionada");
			text.AddTranslation(GameCulture.Chinese, "选择配方");
			AddTranslation(text);

			text = CreateTranslation("Ingredients");
			text.SetDefault("Ingredients");
			text.AddTranslation(GameCulture.French, "Ingrédients");
			text.AddTranslation(GameCulture.Spanish, "Ingredientes");
			text.AddTranslation(GameCulture.Chinese, "材料");
			AddTranslation(text);

			text = CreateTranslation("StoredItems");
			text.SetDefault("Stored Ingredients");
			text.AddTranslation(GameCulture.French, "Ingrédients Stockés");
			text.AddTranslation(GameCulture.Spanish, "Ingredientes almacenados");
			text.AddTranslation(GameCulture.Chinese, "存储中的材料");
			AddTranslation(text);

			text = CreateTranslation("RecipeAvailable");
			text.SetDefault("Show craftable recipes");
			AddTranslation(text);

			text = CreateTranslation("RecipeAll");
			text.SetDefault("Show all known recipes");
			AddTranslation(text);

			text = CreateTranslation("RecipeBlacklist");
			text.SetDefault("Show hidden recipes (ctrl+click on recipe to (un)hide)");
			AddTranslation(text);

			text = CreateTranslation("SortDps");
			text.SetDefault("Sort by DPS");
			AddTranslation(text);

			text = CreateTranslation("ShowOnlyFavorited");
			text.SetDefault("Only Favorited");
			AddTranslation(text);

			text = CreateTranslation("DepositTooltip");
			text.SetDefault("Quick Stack - click, Deposit All - ctrl+click, Restock - right click");
			AddTranslation(text);

			text = CreateTranslation("DepositTooltipAlt");
			text.SetDefault("Quick Stack - ctrl+click, Deposit All - click, Restock - right click");
			AddTranslation(text);

			text = CreateTranslation("CraftTooltip");
			text.SetDefault("Left click to Craft, Right click to get item for a test (only for new items)");
			AddTranslation(text);

			text = CreateTranslation("TestItemSuffix");
			text.SetDefault(" !UNTIL RESPAWN!");
			AddTranslation(text);
		}
	}
}

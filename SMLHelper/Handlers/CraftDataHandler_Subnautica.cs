﻿#if SUBNAUTICA
namespace SMLHelper.Handlers
{
    using Crafting;
    using Patchers;
#if SUBNAUTICA
    using static CraftData;
#endif

    /// <summary>
    /// A handler class for adding and editing crafted items.
    /// </summary>
    public partial class CraftDataHandler
    {
        /// <summary>
        /// <para>Allows you to edit recipes, i.e. TechData for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose TechData you want to edit.</param>
        /// <param name="techData">The TechData for that TechType.</param>
        /// <seealso cref="RecipeData"/>
        public static void SetTechData(TechType techType, ITechData techData)
        {
            CraftDataPatcher.CustomTechData[techType] = techData;
        }

        /// <summary>
        /// <para>Allows you to edit recipes, i.e. TechData for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose TechData you want to edit.</param>
        /// <param name="techData">The TechData for that TechType.</param>
        /// <seealso cref="RecipeData"/>
        public static void SetTechData(TechType techType, RecipeData techData)
        {
            CraftDataPatcher.CustomTechData[techType] = techData;
        }

        /// <summary>
        /// <para>Allows you to edit EquipmentTypes for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose EqiupmentType you want to edit.</param>
        /// <param name="equipmentType">The EquipmentType for that TechType.</param>
        public static void SetEquipmentType(TechType techType, EquipmentType equipmentType)
        {
            CraftDataPatcher.CustomEquipmentTypes[techType] = equipmentType;
        }

        /// <summary>
        /// <para>Allows you to edit QuickSlotType for TechTypes. Can be used for existing TechTypes too.</para>
        /// <para>Careful: This has to be called after <see cref="SetTechData(TechType, ITechData)"/> and <see cref="SetTechData(TechType, RecipeData)"/>.</para>
        /// </summary>
        /// <param name="techType">The TechType whose QuickSlotType you want to edit.</param>
        /// <param name="slotType">The QuickSlotType for that TechType.</param>
        public static void SetQuickSlotType(TechType techType, QuickSlotType slotType)
        {
            CraftDataPatcher.CustomSlotTypes[techType] = slotType;
        }

        /// <summary>
        /// <para>Allows you to edit harvest output, i.e. what TechType you get when you "harvest" a TechType.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose harvest output you want to edit.</param>
        /// <param name="harvestOutput">The harvest output for that TechType.</param>
        public static void SetHarvestOutput(TechType techType, TechType harvestOutput)
        {
            CraftDataPatcher.CustomHarvestOutputList[techType] = harvestOutput;
        }

        /// <summary>
        /// <para>Allows you to edit how TechTypes are harvested.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose HarvestType you want to edit.</param>
        /// <param name="harvestType">The HarvestType for that TechType.</param>
        public static void SetHarvestType(TechType techType, HarvestType harvestType)
        {
            CraftDataPatcher.CustomHarvestTypeList[techType] = harvestType;
        }

        /// <summary>
        /// <para>Allows you to edit how much additional slices/seeds are given upon last knife hit.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose final cut bonus you want to edit.</param>
        /// <param name="bonus">The number of additional slices/seeds you'll receive on last cut.</param>
        public static void SetHarvestFinalCutBonus(TechType techType, int bonus)
        {
            CraftDataPatcher.CustomFinalCutBonusList[techType] = bonus;
        }

        /// <summary>
        /// <para>Allows you to edit item sizes for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose item size you want to edit.</param>
        /// <param name="size">The item size for that TechType.</param>
        public static void SetItemSize(TechType techType, Vector2int size)
        {
            CraftDataPatcher.CustomItemSizes[techType] = size;
        }

        /// <summary>
        /// <para>Allows you to edit item sizes for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose item size you want to edit.</param>
        /// <param name="x">The width of the item</param>
        /// <param name="y">The height of the item</param>
        public static void SetItemSize(TechType techType, int x, int y)
        {
            CraftDataPatcher.CustomItemSizes[techType] = new Vector2int(x, y);
        }

        /// <summary>
        /// <para>Allows you to edit crafting times for TechTypes.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="techType">The TechType whose crafting time you want to edit.</param>
        /// <param name="time">The crafting time, in seconds, for that TechType.</param>
        public static void SetCraftingTime(TechType techType, float time)
        {
            CraftDataPatcher.CustomCraftingTimes[techType] = time;
        }

        /// <summary>
        /// <para>Allows you to edit the cooked creature list, i.e. associate the unedible TechType to the cooked TechType.</para>
        /// <para>Can be used for existing TechTypes too.</para>
        /// </summary>
        /// <param name="uncooked">The TechType whose cooked creature counterpart to edit.</param>
        /// <param name="cooked">The cooked creature counterpart for that TechType.</param>
        public static void SetCookedVariant(TechType uncooked, TechType cooked)
        {
            CraftDataPatcher.CustomCookedCreatureList[uncooked] = cooked;
        }

        /// <summary>
        /// <para>Allows you to edit inventory background colors for TechTypes.</para>
        /// </summary>
        /// <param name="techType">The TechType whose BackgroundType you want to edit.</param>
        /// <param name="backgroundColor">The background color for that TechType.</param>
        /// <seealso cref="CraftData.BackgroundType"/>
        public static void SetBackgroundType(TechType techType, CraftData.BackgroundType backgroundColor)
        {
            CraftDataPatcher.CustomBackgroundTypes[techType] = backgroundColor;
        }

        /// <summary>
        /// Sets the eating sound for the provided TechType.
        /// </summary>
        /// <param name="consumable">The item being consumed during <see cref="Survival.Eat(UnityEngine.GameObject)"/>.</param>
        /// <param name="soundPath">
        /// The sound path.
        /// <para>
        /// Value values are
        /// - "event:/player/drink"
        /// - "event:/player/drink_stillsuit"
        /// - "event:/player/use_first_aid"
        /// - "event:/player/eat" (default)
        /// </para>
        /// </param>
        public static void SetEatingSound(TechType consumable, string soundPath)
        {
            CraftDataPatcher.CustomEatingSounds.Add(consumable, soundPath);
        }

        /// <summary>
        /// Allows you to add items to the buildable list.
        /// </summary>
        /// <param name="techType">The TechType which you want to add to the buildable list.</param>
        public static void AddBuildable(TechType techType)
        {
            CraftDataPatcher.CustomBuildables.Add(techType);
        }

        /// <summary>
        /// Safely accesses the crafting data from a modded item.<para/>
        /// WARNING: This method is highly dependent on mod load order. 
        /// Make sure your mod is loading after the mod whose TechData you are trying to access.
        /// </summary>
        /// <param name="techType">The TechType whose TechData you want to access.</param>
        /// <returns>The ITechData from the modded item if it exists; Otherwise, returns <c>null</c>.</returns>
        public static ITechData GetModdedTechData(TechType techType)
        {
            if (!CraftDataPatcher.CustomTechData.TryGetValue(techType, out ITechData moddedTechData))
            {
                return null;
            }
            return moddedTechData;
        }

        /// <summary>
        /// Safely accesses the crafting data from any item.<para/>
        /// WARNING: This method is highly dependent on mod load order. 
        /// Make sure your mod is loading after the mod whose TechData you are trying to access.
        /// </summary>
        /// <param name="techType">The TechType whose TechData you want to access.</param>
        /// <returns>Returns TechData if it exists; Otherwise, returns <c>null</c>.</returns>
        public static RecipeData GetTechData(TechType techType)
        {
            if (CraftDataPatcher.CustomTechData.TryGetValue(techType, out ITechData iTechData))
            {
                return ConvertToTechData(iTechData);
            }

            iTechData = CraftData.Get(techType, true);

            if (iTechData != null)
            {
                return ConvertToTechData(iTechData);
            }

            return null;
        }

        /// <summary>
        /// Safely accesses the crafting data from any item.<para/>
        /// WARNING: This method is highly dependent on mod load order. 
        /// Make sure your mod is loading after the mod whose TechData you are trying to access.
        /// </summary>
        /// <param name="techType">The TechType whose TechData you want to access.</param>
        /// <returns>Returns TechData if it exists; Otherwise, returns <c>null</c>.</returns>
        public static RecipeData GetRecipeData(TechType techType)
        {
            if(CraftDataPatcher.CustomTechData.TryGetValue(techType, out ITechData iTechData))
            {
                return ConvertToTechData(iTechData);
            }

            iTechData = CraftData.Get(techType, true);

            if(iTechData != null)
            {
                return ConvertToTechData(iTechData);
            }

            return null;
        }

        private static RecipeData ConvertToTechData(ITechData iTechData)
        {
            var techData = new RecipeData() { craftAmount = iTechData.craftAmount };

            for (int i = 0; i < iTechData.ingredientCount; i++)
            {
                IIngredient ingredient = iTechData.GetIngredient(i);
                var smlingredient = new Ingredient(ingredient.techType, ingredient.amount);
                techData.Ingredients.Add(smlingredient);
            }

            for (int i = 0; i < iTechData.linkedItemCount; i++)
            {
                techData.LinkedItems.Add(iTechData.GetLinkedItem(i));
            }

            return techData;
        }
    }
}
#endif
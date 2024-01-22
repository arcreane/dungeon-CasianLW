
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Chest {
    private List<Item> itemsInChest;


    public Chest(IEnumerable<Item> items)
    {
        itemsInChest = new List<Item>(items);

    }


    public IEnumerable<Item> Open()
    {
        // Logic to determine which items are selected when the chest is opened
        SelectItems();

        // Return the selected items to whoever opened the chest
        return itemsInChest;
    }


    public void SelectItems() {
        // TODO implement here

        // If there is some logic to select items, implement here.
        // This could involve random selection or based on the hero's stats or needs.
        // For example, if the chest should only yield a certain type of item:
        // itemsInChest.RemoveAll(item => !item.IsType(hero.NeedsType));
    }


}
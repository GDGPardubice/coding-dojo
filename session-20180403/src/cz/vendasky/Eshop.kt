package cz.vendasky

class Eshop (
    val name: String
) {

    val items: MutableList<EshopItem> = mutableListOf()

    fun addProduct(eshopItem: EshopItem) {
        items.add(eshopItem)
    }
}
package cz.vendasky

class FinestCalculator(val eshops: List<Eshop>) {

    fun findTheOrder(wishList: List<WishListRecord>): Order {
        var wantedItemName = wishList[0].name
        var bestPrice = Int.MAX_VALUE
        var bestEshopName = ""
        eshops.forEach { eshop ->
            run {
                eshop.items.forEach {
                    if (it.itemName == wantedItemName) {
                        if (it.price < bestPrice) {
                            bestPrice = it.price
                            bestEshopName = eshop.name
                        }
                    }
                }
            }
        }
        return Order(bestEshopName)
    }
}
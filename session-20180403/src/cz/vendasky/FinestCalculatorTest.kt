package cz.vendasky

import org.junit.jupiter.api.Assertions.*
import org.junit.jupiter.api.BeforeAll
import org.junit.jupiter.api.BeforeEach
import org.junit.jupiter.api.Test

class FinestCalculatorTest {

    var eshopsEasy = listOf<Eshop>()
    var eshopsFull = listOf<Eshop>()

    @BeforeEach
    fun init() {
        val eshopABC = Eshop("ABC")
        eshopABC.addProduct(EshopItem("Product A", 77))

        val eshopA = Eshop("A")
        val eshopB = Eshop("B")
        val eshopC = Eshop("C")

        eshopA.addProduct(EshopItem("Product A", 10))
        eshopA.addProduct(EshopItem("Product B", 12))
        eshopA.addProduct(EshopItem("Product C", 15))

        eshopB.addProduct(EshopItem("Product A", 5))
        eshopB.addProduct(EshopItem("Product B", 20))
        eshopB.addProduct(EshopItem("Product C", 15))

        eshopC.addProduct(EshopItem("Product A", 7))
        eshopC.addProduct(EshopItem("Product B", 22))
        eshopC.addProduct(EshopItem("Product C", 16))

        eshopsEasy = listOf(eshopABC)
        eshopsFull = listOf(eshopA, eshopB, eshopC)
    }

    @Test
    fun bestOrderFromOneEshop() {
        val wishList = listOf(WishListRecord("Product A", 1))
        val finestCalculator = FinestCalculator(eshopsEasy)
        assertEquals("ABC", finestCalculator.findTheOrder(wishList).eshopName)
    }

    @Test
    fun bestOrderForProductAFrom3Eshops() {
        val wishList = listOf(WishListRecord("Product A", 1))
        val finestCalculator = FinestCalculator(eshopsFull)
        assertEquals("B", finestCalculator.findTheOrder(wishList).eshopName)
    }

    @Test
    fun bestOrderForProductBFrom3Eshops() {
        val wishList = listOf(WishListRecord("Product B", 1))
        val finestCalculator = FinestCalculator(eshopsFull)
        assertEquals("A", finestCalculator.findTheOrder(wishList).eshopName)
    }

}
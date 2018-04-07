# E-shop Kata

## Problem Description
We have e-shops selling many products. Each e-shop offers products at a specific price and in a certain amount. E-shops allow to pick up the order at the store or they can send it by post/courier. In that case, you have to pay for the shipping (unless your order is over a certain price). The problem is to find an e-shop (or combination of them) where the total price you pay is the lowest.

## Orders to solve
- The order consists only of goods available in all shops. We will pick up the order at the store. (All goods are available in all shops. We will order only from one shop and we will pick it up at the store.)
- The order consists of goods that aren’t available at some shop. We will pick up the order at the store. (Some goods are not available in some shops. We need to find a shop with all required goods available. We will pick up the order at the store.)
- We can split the order into more orders from different shops to save money as much as possible. We will pick up the order 
  at the stores.
- The orders will be sent by courier.We have to pay for shipping.
  - The shipping is free over a certain total price (calculated per shop)

## We can ignore
- Quality of e-shops.
- Different units than pieces.
- Different currencies.
- Information about a delivery address.

## Possible modifications
- Known date of stocking. The customer can wait for the goods (he can wait up to a certain date or he doesn't care about the date at all – he just wants the cheapest).
- There can be benefits for registered customers:
- Discount on the total price
- Free shipping
- Some e-shop can offer discounts (discounted packs, time-limited discounts etc.)

## Session

- **Date**: 3. 4. 2018
- **Place**: Univerzita Pardubice - Fakulta Elektrotechniky a Informatiky
- **Participants**: Václav Pavlíček, Vojtěch Müller, Emil Řezanina, Petr Filip, Martin Jakeš, Lukáš Trumm, Tomáš Tintěra
- **IDE/Language**: IntelliJ IDEA 2018/JUnit/Kotlin
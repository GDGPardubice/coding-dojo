import * as _ from 'lodash';

interface Card {
    color: 'C' | 'D' | 'H' | 'S';
    rank: Rank;
}
type Rank = 'A' | 'K' | 'Q' | 'J' | 'T' | '9' | '8' | '7' | '6' | '5' | '4' | '3' | '2';
type Hand = [Card, Card, Card, Card, Card];

export const FirstIsHigher = 1;
export const HandsEqual = 0;
export const SecondIsHigher = -1;

export function compare(firstHand: Hand, secondHand: Hand) {
    if (isStraightFlush(firstHand) && isStraightFlush(secondHand)) {
        if (findHighestCard(firstHand) > findHighestCard(secondHand)) {
            return FirstIsHigher;
        } else if (findHighestCard(secondHand) > findHighestCard(firstHand)) {
            return SecondIsHigher;
        } else {
            return HandsEqual;
        }
    }

    return FirstIsHigher;
}

function isStraightFlush(hand: Hand): boolean {
    return isFlush(hand) && isStraight(hand);
}

function isFlush(hand: Hand): boolean {
    const firstColor = hand[0].color;
    for (let i = 1; i < hand.length; i++) {
        if (firstColor !== hand[i].color) {
            return false;
        }
    }
    return true;
}

function isStraight(hand: Hand): boolean {
    const sortedHand = hand.slice().sort((a: Card, b: Card) => compareRanks(a.rank, b.rank));;
    for (let i = 1; i < sortedHand.length; i++) {
        if (parseRank(sortedHand[i - 1].rank) + 1 !== parseRank(sortedHand[i].rank)) {
            return false;
        }
    }
    return true;
}

function findHighestCard(hand: Hand) {
    return Math.max(...hand.map((a: Card) => parseRank(a.rank)));
}

function compareRanks(firstRank: Rank, secondRank: Rank) {
    if (parseRank(firstRank) == parseRank(secondRank)) {
        return HandsEqual;
    }
    return (parseRank(firstRank) > parseRank(secondRank)) ? FirstIsHigher : SecondIsHigher;
}

function parseRank(rank: Rank): number {
    if (rank <= '9') {
        return parseInt(rank, 10);
    }

    const ranks: any = {T: 10, J: 11, Q: 12, K: 13, A: 14};
    return ranks[rank];
}

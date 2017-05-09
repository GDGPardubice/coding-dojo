import {expect} from 'chai';
import * as PokerHand from '../src/PokerHand';

describe('PokerHand', () => {
    it('players with same straight flush are equal', () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}, {color: 'C', rank: '9'}],
            [{color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}, {color: 'C', rank: '9'}]
        )).to.equal(PokerHand.HandsEqual);
    });

    it(`ranks first hand's higher straight flush higher`, () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}, {color: 'C', rank: '9'}],
            [{color: 'C', rank: '4'}, {color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}]
        )).to.equal(PokerHand.FirstIsHigher);
    });

    it(`ranks second hand's higher straight flush higher`, () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '4'}, {color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}],
            [{color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}, {color: 'C', rank: '9'}]
        )).to.equal(PokerHand.SecondIsHigher);
    });

    it(`ranks second hand's higher straight flush higher than unsorted first straight flush`, () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '6'}, {color: 'C', rank: '4'}, {color: 'C', rank: '5'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}],
            [{color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}, {color: 'C', rank: '9'}]
        )).to.equal(PokerHand.SecondIsHigher);
    });

    it(`ranks second hand's higher straight flush with letter higher than unsorted first straight flush`, () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '6'}, {color: 'C', rank: '4'}, {color: 'C', rank: '5'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}],
            [{color: 'C', rank: '6'}, {color: 'C', rank: '7'}, {color: 'C', rank: '8'},
                {color: 'C', rank: '9'}, {color: 'C', rank: 'T'}]
        )).to.equal(PokerHand.SecondIsHigher);
    });

    it(`ranks straight flush higher than not-straight ascending sequence`, () => {
        expect(PokerHand.compare(
            [{color: 'C', rank: '4'}, {color: 'C', rank: '5'}, {color: 'C', rank: '6'}, {color: 'C', rank: '7'},
                {color: 'C', rank: '8'}],
            [{color: 'C', rank: '2'}, {color: 'C', rank: '7'}, {color: 'C', rank: '8'},
                {color: 'C', rank: '9'}, {color: 'C', rank: 'T'}]
        )).to.equal(PokerHand.FirstIsHigher);
    });
});

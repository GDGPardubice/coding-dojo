import {expect} from 'chai';
import {getFizzBuzz, getFizzBuzzRange, FIZZ, BUZZ, FIZZBUZZ} from '../src/FizzBuzz';

describe('FizzBuzz', () => {
    describe('single value', () => {
        it('returns "1" for 1', () => {
            expect(getFizzBuzz(1)).to.equal('1');
        })
        it('returns "2" for 2', () => {
            expect(getFizzBuzz(2)).to.equal('2');
        })
        it(`returns ${FIZZBUZZ} for 15`, () => {
            expect(getFizzBuzz(15)).to.equal(FIZZBUZZ);
        })
        it(`A number is ${FIZZ} if it is divisible by 3 or if it has a 3 in it`, () => {
            expect(getFizzBuzz(3)).to.equal(FIZZ);
        })
        it(`A number is ${BUZZ} if it is divisible by 5 or if it has a 5 in it`, () => {
            expect(getFizzBuzz(5)).to.equal(BUZZ);
        })
    })

    describe('range', () => {
        it('returns ["1"] for range 1..1', () => {
            expect(getFizzBuzzRange(1, 1)).to.deep.eq(['1']);
        })
        it('returns correct value for range 1..5', () => {
            expect(getFizzBuzzRange(1, 5)).to.deep.eq(['1', '2', FIZZ, '4', BUZZ]);
        })
        it('returns correct value for range 11..16', () => {
            expect(getFizzBuzzRange(11, 16)).to.deep.eq(['11', FIZZ, FIZZ, '14', FIZZBUZZ, '16']);
        })
    })
});

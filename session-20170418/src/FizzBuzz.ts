import * as _ from 'lodash';

export const FIZZ = 'fizz';
export const BUZZ = 'buzz';
export const FIZZBUZZ = 'fizzbuzz';

export function getFizzBuzzRange(from: number, to: number): string[] {
    return _.range(from, to + 1).map(getFizzBuzz);
}

export function getFizzBuzz(value: number): string {
    let isFizz = value % 3 === 0 || `${value}`.includes('3');
    let isBuzz = value % 5 === 0 || `${value}`.includes('5');

    if (isFizz && isBuzz)
        return FIZZBUZZ;

    if (isBuzz)
        return BUZZ;

    if (isFizz)
        return FIZZ;

    return `${value}`;
}

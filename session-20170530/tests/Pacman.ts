import {expect} from 'chai';
import {Pacman} from '../src/Pacman';


describe('Pacman', () => {

    it('looks to right direction at start', () => {
        let pacman = new Pacman();
        expect(pacman.getDirection()).to.equal("RIGHT");
    });

    it('can look to the left', () => {
        let pacman = new Pacman();
        pacman.setDirection("LEFT");
        expect(pacman.getDirection()).to.equal("LEFT");
    });

    it('can look down', () => {
        let pacman = new Pacman();
        pacman.setDirection("DOWN");
        expect(pacman.getDirection()).to.equal("DOWN");
    });

    it('can look up', () => {
        let pacman = new Pacman();
        pacman.setDirection("UP");
        expect(pacman.getDirection()).to.equal("UP");
    });
});

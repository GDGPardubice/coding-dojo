import {expect} from 'chai';
import {Pacman} from '../src/Pacman';
import {GameControl} from "../src/GameControl";

describe('GameControl', () => {

    it('put pacman to default position', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 0, y: 0});
    });

    it('moves pacman', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 1, y: 0});
    });

    it('moves pacman on two ticks two steps right', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        gameControl.tick();
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 2, y: 0});
    });

    it('when direction is up, moves pacman up', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        pacman.setDirection("UP");
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 0, y: 1});
    });

    it('tick, then turns up and then tick again', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        gameControl.tick();
        pacman.setDirection("UP");
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 1, y: 1});
    });

    it('tick, then turns left and then tick again', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        gameControl.tick();
        pacman.setDirection("LEFT");
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 0, y: 0});
    });

    it('tick, then turns left and then tick again', () => {
        let pacman = new Pacman();
        let gameControl = new GameControl(pacman);
        gameControl.tick();
        pacman.setDirection("DOWN");
        gameControl.tick();
        expect(gameControl.getPacmanPosition()).to.deep.eq({x: 1, y: -1});
    });
});
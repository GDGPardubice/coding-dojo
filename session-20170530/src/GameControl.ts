import {Pacman} from "./Pacman";
export class GameControl {

    constructor(private pacman: Pacman) {
    }

    private pacmanPosition = {x: 0, y: 0};

    tick() {
        this.updatePacmanPosition();
    }

    private updatePacmanPosition() {
        switch (this.pacman.getDirection()) {
            case "UP":
                this.pacmanPosition.y += 1;
                break;
            case "LEFT":
                this.pacmanPosition.x -= 1;
                break;
            case "DOWN":
                this.pacmanPosition.y -= 1;
                break;
            default:
                this.pacmanPosition.x += 1;
        }
    }

    getPacmanPosition() {
        return this.pacmanPosition;
    }
}
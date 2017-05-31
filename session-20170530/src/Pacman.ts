export type Direction = "LEFT" | "RIGHT" | "UP" | "DOWN";

export class Pacman {

    private direction: Direction = "RIGHT";

    getDirection(): Direction {
        return this.direction;
    }

    setDirection(directiction: Direction) {
        this.direction = directiction;
    }
}


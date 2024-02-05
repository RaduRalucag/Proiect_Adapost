import { Conditie } from "./Conditie";
import { Arhiva } from "./Arhiva";

export interface Control {
    id: string;
    data: string;
    Conditie: Conditie;
    Arhiva: Arhiva;
    }
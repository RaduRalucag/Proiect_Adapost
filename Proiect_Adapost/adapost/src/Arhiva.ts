import { Control } from "./Control";

export interface Arhiva {
    id : string;
    categorie : string;
    descriere : string;
    Controls : Control[];
}
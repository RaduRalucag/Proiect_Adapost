import { Role } from "./Role";

export interface User {
    id: string;
    nume: string;
    parolaHash: string;
    refreshToken: string;
    tokenCreated: string;
    tokenExpires: string;
    Roles: Role[];
    }
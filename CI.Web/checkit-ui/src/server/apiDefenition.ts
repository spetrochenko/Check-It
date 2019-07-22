import { CreateUserViewModel, BoardViewModel } from "../models/models"

export class userApiController {

    public createUser(createUserViewModel: CreateUserViewModel): Promise<any> {
        return fetch('api/UserController/CreateUser', { method: 'POST', headers: { 'Content-Type': 'application/json' }, body: JSON.stringify(createUserViewModel) });
    }

}

export class boardApiController {

    public createUser(boardViewModel: BoardViewModel): Promise<any> {
        return fetch('api/BoardController/CreateBoard', { method: 'POST', headers: { 'Content-Type': 'application/json' }, body: JSON.stringify(boardViewModel) });
    }

    public loadById(id: number): Promise<any> {
        return fetch('api/BoardController/LoadBoardById', { method: 'GET', });
    }
}
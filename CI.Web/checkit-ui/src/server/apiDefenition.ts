import { CreateUserViewModel } from "../models/models"

export class userApiController {

    public createUser(createUserViewModel: CreateUserViewModel): Promise<any> {
        return fetch('api/UserController/CreateUser', { method: 'POST', headers: { 'Content-Type': 'application/json' }, body: JSON.stringify(createUserViewModel) });
    }

}
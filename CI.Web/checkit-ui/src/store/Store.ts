import { createStore } from 'redux';
import rootReducer from '../reducers/Reducer';

const Store = createStore(rootReducer);

export default Store;
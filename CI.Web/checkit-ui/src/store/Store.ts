import { createStore } from 'redux';
import rootReducer from '../reducers/RootReducer';

const Store = createStore(rootReducer);

export default Store;
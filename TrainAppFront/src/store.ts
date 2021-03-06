import { init, RematchRootState } from '@rematch/core';
import models from './models';

export const store = init({
	models
});

export const dispatch = store.dispatch;

export type Store = typeof store
export type Dispatch = typeof store.dispatch
export type iRootState = RematchRootState<typeof models>
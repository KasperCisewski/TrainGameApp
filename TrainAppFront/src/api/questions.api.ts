import Api from './Api';

export const getInitialQuestionR = () => Api.get(`/question/getQuestionWithAnswers?token=cos`);
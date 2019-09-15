export const isJSON = (str: string): boolean => {
	try {
		JSON.parse(str);
	} catch (err) {
		return false;
	}
	return true;
};
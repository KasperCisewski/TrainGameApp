import React, { useState } from 'react';
import { TextInputWrapper } from "./TextInput.style";
import {errorIcon} from "../assets";

interface Props {
	type: string
	value: string
	onChange: (e: any) => void,
	placeholder?: string,
	width?: string,
	errorMessage?: string
}

const TextInput: React.FC<Props> = ({
	type,
	value,
	onChange,
	placeholder,
	width,
	errorMessage
}: Props) => {
	const [isFocused, changeFocus] = useState(false);
	const [isShowingError, changeErrorState] = useState(false);

	const showTooltipError = () => changeErrorState(true);

	const hideTooltipError = () => changeErrorState(false);

	return (
		<TextInputWrapper hasError={!!errorMessage} focused={isFocused || !!value} width={width}>
			<span>{placeholder}</span>
			<input onFocus={() => changeFocus(true)} onBlur={() => changeFocus(false)} value={value} onChange={onChange} type={type}/>
			{
				errorMessage && (
					<img onMouseEnter={showTooltipError} onMouseLeave={hideTooltipError} src={errorIcon} alt=""/>
					)
			}
			{
				isShowingError && (
					<div>
						<span>{errorMessage}</span>
					</div>
				)
			}
		</TextInputWrapper>
	)
};

export default TextInput;
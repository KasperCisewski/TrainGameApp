import React from 'react';
import {ButtonWrapper} from './Button.style';

interface Props {
	label: string,
	onClick: () => void,
	margin?: string,
	padding?: string,
	width?: string
}

const Button: React.FC<Props> = ({
	label,
	onClick,
	margin,
	padding,
	width
}: Props) => {
	return (
		<ButtonWrapper onClick={onClick} margin={margin} padding={padding} width={width}>
			{label}
		</ButtonWrapper>
	)
};

export default Button;